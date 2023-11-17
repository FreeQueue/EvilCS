namespace SimpleECS;

public struct StructureEventHandler
{
    public StructureEventHandler(WorldInfo world) {
        _cacheEvents = 0;
        _events = new();
        _world = world;
    }

    private readonly WorldInfo _world;
    private int _cacheEvents;

    public int EnqueueEvents {
        get => _cacheEvents;
        set {
            _cacheEvents = value;
            ExecuteEventPlayback();
        }
    }

    private readonly Queue<EventData> _events;

    private struct EventData
    {
        public EventType type;
        public Entity entity;
        public int type_Id;
        public Archetype archetype;
        public World world;
    }

    private enum EventType
    {
        CreateEntity,
        DestroyEntity,
        SetComponent,
        RemoveComponent,
        TransferEntity,
        DestroyArchetype,
        DestroyWorld,
        ResizeBackingArrays
    }

    public void ExecuteEventPlayback() {
        while (_cacheEvents == 0 && _events.Count > 0) {
            var e = _events.Dequeue();
            switch (e.type) {
                case EventType.CreateEntity: {
                    ref var archData = ref _world.archetypes[e.archetype.index];
                    if (archData.version == e.archetype.version) {
                        SetUpEntity(e.entity, _world.archetypes[e.archetype.index].data);
                    }
                    else {
                        Entities.all[e.entity.index].world_Info = default;
                        Entities.free.Enqueue(e.entity.index);
                    }
                }
                    break;

                case EventType.SetComponent:
                    _world.GetData(e.type_Id).Set(e.entity, this);
                    break;

                case EventType.RemoveComponent:
                    _world.GetData(e.type_Id).Remove(e.entity, this);
                    break;

                case EventType.DestroyEntity:
                    Destroy(e.entity);
                    break;

                case EventType.TransferEntity:
                    Transfer(e.entity, e.world);
                    break;

                case EventType.DestroyArchetype:
                    DestroyArchetype(e.archetype);
                    break;

                case EventType.DestroyWorld:
                    DestroyWorld();
                    break;

                case EventType.ResizeBackingArrays:
                    ResizeBackingArrays(e.archetype);
                    break;
            }
        }
    }

    public Entity CreateEntity(ArchetypeInfo archetypeData) {
        int index = 0;
        if (Entities.free.Count > 0) {
            index = Entities.free.Dequeue();
        }
        else {
            index = Entities.last;
            if (index == Entities.all.Length)
                Array.Resize(ref Entities.all, index * 2);
            Entities.last++;
        }
        int version = Entities.all[index].version;
        var entity = new Entity(index, version);
        Entities.all[index].world_Info = _world;

        if (_cacheEvents > 0) {
            Entities.all[index].version++;
            _events.Enqueue(new() {
                type = EventType.CreateEntity, entity = entity, archetype = archetypeData.archetype
            });
        }
        else {
            SetUpEntity(entity, archetypeData);
        }
        return entity;
    }

    private void SetUpEntity(Entity entity, ArchetypeInfo archetypeData) {
        ref var entityData = ref Entities.all[entity.index];
        entityData.version = entity.version;
        entityData.arch_Info = archetypeData;
        int archIndex = entityData.arch_Index = archetypeData.entity_Count;
        archetypeData.entity_Count++;
        archetypeData.world_Info.entity_Count++;
        archetypeData.EnsureCapacity(archIndex);
        archetypeData.entities[archIndex] = entity;
    }

    public void Set<TComponent>(in Entity entity, in TComponent component) {
        var worldData = _world.GetData<TComponent>();
        if (_cacheEvents > 0) {
            worldData.set_Queue.Enqueue(component);
            _events.Enqueue(new() {
                type = EventType.SetComponent, entity = entity, type_Id = TypeId<TComponent>.Value
            });
            return;
        }

        ref var entityInfo = ref Entities.all[entity.index];
        if (entityInfo.version == entity.version) {
            if (entityInfo.arch_Info.TryGetArray<TComponent>(out var buffer)) {
                int index = entityInfo.arch_Index;
                var old = buffer[index];
                buffer[index] = component;
                worldData.set_Callback?.Invoke(entity, old, ref buffer[index]);
            }
            else {
                int oldIndex = entityInfo.arch_Index;
                var archetype = entityInfo.arch_Info;
                int lastIndex = --archetype.entity_Count;
                var last = archetype.entities[oldIndex] = archetype.entities[lastIndex];
                Entities.all[last.index].arch_Index =
                    oldIndex; // reassign moved entity to to index

                // adding entity to target archetype
                var targetArchetype = entityInfo.arch_Info =
                    _world.GetArchetypeData(_world.bufferSignature.Copy(archetype.signature)
                        .Add<TComponent>());
                int targetIndex = entityInfo.arch_Index = targetArchetype.entity_Count;
                targetArchetype.EnsureCapacity(targetIndex);
                targetArchetype.entity_Count++;

                // moving components over
                targetArchetype.entities[targetIndex] = entity;
                for (int i = 0; i < archetype.component_Count; ++i)
                    archetype.component_Buffers[i].buffer.Move(oldIndex, lastIndex,
                        targetArchetype, targetIndex);

                // setting the added component and calling the callback event
                if (targetArchetype.TryGetArray<TComponent>(out var targetBuffer)) {
                    targetBuffer[targetIndex] = component;
                    worldData.set_Callback?.Invoke(entity, default,
                        ref targetBuffer[targetIndex]);
                }
                else {
                    throw new("Frame Work Bug");
                }
            }
        }
    }

    public void Remove<TComponent>(in Entity entity) {
        int typeId = TypeId<TComponent>.Value;
        if (_cacheEvents > 0) {
            _events.Enqueue(new()
                { type = EventType.RemoveComponent, entity = entity, type_Id = typeId });
        }
        else {
            ref var entityInfo = ref Entities.all[entity.index];
            if (entity.version == entityInfo.version) {
                var oldArch = entityInfo.arch_Info;
                if (oldArch.TryGetArray<TComponent>(
                        out var oldBuffer)) // if archetype already has component, just set and fire event
                {
                    int oldIndex = entityInfo.arch_Index;

                    var targetArch = _world.GetArchetypeData(_world.bufferSignature
                        .Copy(oldArch.signature).Remove(typeId));
                    int targetIndex = targetArch.entity_Count;
                    targetArch.entity_Count++;
                    targetArch.EnsureCapacity(targetIndex);

                    oldArch.entity_Count--;
                    int lastIndex = oldArch.entity_Count;
                    var last = oldArch.entities[oldIndex] = oldArch.entities[lastIndex];
                    Entities.all[last.index].arch_Index = oldIndex;

                    entityInfo.arch_Index = targetIndex;
                    entityInfo.arch_Info = targetArch;

                    targetArch.entities[targetIndex] = entity;
                    var removed = oldBuffer[oldIndex];
                    for (int i = 0; i < oldArch.component_Count; ++i)
                        oldArch.component_Buffers[i].buffer.Move(oldIndex, lastIndex,
                            targetArch, targetIndex);
                    _world.GetData<TComponent>().remove_Callback?.Invoke(entity, removed);
                }
            }
        }
    }

    public void Transfer(Entity entity, World targetWorld) {
        if (_cacheEvents > 0) {
            _events.Enqueue(new()
                { type = EventType.TransferEntity, entity = entity, world = targetWorld });
        }
        else {
            ref var entityInfo = ref Entities.all[entity.index];
            if (entityInfo.version == entity.version
                && entityInfo.arch_Info.world_Info.world != targetWorld
                && targetWorld.TryGetWorldInfo(out var targetWorldInfo)) {
                var targetArch =
                    targetWorldInfo.GetArchetypeData(entityInfo.arch_Info.signature);
                int targetIndex = targetArch.entity_Count;
                targetArch.EnsureCapacity(targetIndex);
                targetArch.entity_Count++;
                targetArch.world_Info.entity_Count++;

                int oldIndex = entityInfo.arch_Index;
                var oldArch = entityInfo.arch_Info;
                int lastIndex = --oldArch.entity_Count;
                --oldArch.world_Info.entity_Count;

                var last = oldArch.entities[oldIndex] = oldArch.entities[lastIndex];
                Entities.all[last.index].arch_Index = oldIndex;
                targetArch.entities[targetIndex] = entity;

                for (int i = 0; i < oldArch.component_Count; ++i)
                    oldArch.component_Buffers[i].buffer.Move(oldIndex, lastIndex,
                        targetArch.component_Buffers[i].buffer.Array, targetIndex);

                entityInfo.arch_Index = targetIndex;
                entityInfo.arch_Info = targetArch;
                entityInfo.world_Info = targetWorldInfo;
            }
        }
    }

    public void Destroy(Entity entity) {
        if (_cacheEvents > 0) {
            _events.Enqueue(new() { type = EventType.DestroyEntity, entity = entity });
        }
        else {
            ref var entityInfo = ref Entities.all[entity.index];
            if (entityInfo.version == entity.version) {
                entityInfo.version++;
                var oldArch = entityInfo.arch_Info;
                int oldIndex = entityInfo.arch_Index;
                --oldArch.entity_Count;
                --_world.entity_Count;
                int lastIndex = oldArch.entity_Count;
                var last = oldArch.entities[oldIndex] = oldArch.entities[lastIndex]; // swap 
                Entities.all[last.index].arch_Index = oldIndex;

                // this causes allocations
                (WorldData callback, object value)[] removed =
                    new (WorldData, object)[oldArch.component_Count];
                // but other means are quite convuluted
                int length = 0;

                for (int i = 0; i < oldArch.component_Count; ++i) {
                    var pool = oldArch.component_Buffers[i];
                    var callback = _world.GetData(pool.type_Id);
                    if (callback.has_Remove_Callback) {
                        removed[length] = (callback, pool.buffer.Array[entityInfo.arch_Index]);
                        // this causes boxing :(
                        length++;
                    }
                    pool.buffer.Remove(oldIndex, lastIndex);
                }
                entityInfo.version++;
                entityInfo.arch_Info = default;
                entityInfo.world_Info = default;
                Entities.free.Enqueue(entity.index);

                for (int i = 0; i < length; ++i)
                    removed[i].callback.InvokeRemoveCallback(entity, removed[i].value);
            }
        }
    }

    public void DestroyArchetype(Archetype archetype) {
        if (_cacheEvents > 0) {
            _events.Enqueue(new() { type = EventType.DestroyArchetype, archetype = archetype });
        }
        else {
            if (archetype.TryGetArchetypeInfo(out var archInfo)) {
                _world.entity_Count -= archInfo.entity_Count;
                _world.signatureToArchetypeIndex
                    .Remove(archInfo.signature); // update archetype references
                _world.archetypes[archetype.index].version++;
                _world.archetypes[archetype.index].data = default;
                _world.freeArchetypes.Push(archetype.index);
                _world.archetype_Structure_Update_Count++;

                for (int i = 0; i < archInfo.entity_Count; ++i) // remove entities from world
                {
                    var entity = archInfo.entities[i];
                    ref var info = ref Entities.all[entity.index];
                    info.version++;
                    info.arch_Info = default;
                    info.world_Info = default;
                    Entities.free.Enqueue(entity.index);
                }

                for (int i = 0; i < archInfo.component_Count; ++i) // invoke callbacks
                {
                    var pool = archInfo.component_Buffers[i];
                    var callback = _world.GetData(pool.type_Id);
                    if (callback.has_Remove_Callback)
                        callback.InvokeRemoveCallbackAll(archInfo.entities, pool.buffer.Array,
                            archInfo.entity_Count);
                }
            }
        }
    }

    public void DestroyWorld() {
        if (_cacheEvents > 0) {
            _events.Enqueue(new() { type = EventType.DestroyWorld });
        }
        else {
            ref var worldInfo = ref WorldInfo.all[_world.world.index];
            if (worldInfo.version ==
                _world.world
                    .version) // still needs to be checked incase multiple destorys are queued
            {
                worldInfo.version++;
                var data = worldInfo.data;
                worldInfo.data = default;

                foreach (var archetype in data.archetypes) // delete all entities first
                {
                    var archeInfo = archetype.data;
                    if (archeInfo == null) continue;

                    for (int i = 0; i < archeInfo.entity_Count; ++i) {
                        int index = archeInfo.entities[i].index;
                        ref var info = ref Entities.all[index];
                        info.version++;
                        info.arch_Info = default;
                        info.world_Info = default;
                        Entities.free.Enqueue(index);
                    }
                }

                foreach (var archetype in data.archetypes) // then do all their callbacks
                {
                    var archeInfo = archetype.data;
                    if (archeInfo == null) continue;
                    for (int i = 0; i < archeInfo.component_Count; ++i) {
                        var pool = archeInfo.component_Buffers[i];
                        var worldData = data.GetData(pool.type_Id);
                        if (worldData.has_Remove_Callback)
                            worldData.InvokeRemoveCallbackAll(archeInfo.entities,
                                pool.buffer.Array, archeInfo.entity_Count);
                    }
                }
            }
        }
    }

    public void ResizeBackingArrays(Archetype archetype) {
        if (_cacheEvents > 0)
            _events.Enqueue(new() { type = EventType.ResizeBackingArrays, archetype = archetype });
        else if (archetype.TryGetArchetypeInfo(out var info))
            info.ResizeBackingArrays();
    }
}