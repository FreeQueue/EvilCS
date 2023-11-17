using System.Collections;
using System.Diagnostics.Contracts;

namespace SimpleECS;

/// <summary>
///     manages all entities and archetype information
/// </summary>
public readonly partial struct World : IEquatable<World>, IEnumerable<Archetype>
{
    private World(int index, int version) {
        this.index = index;
        this.version = version;
    }

    /// <summary>
    ///     the index and version together create a unique identifier for the world
    /// </summary>
    public readonly int index;

    /// <summary>
    ///     the index and version together create a unique identifier for the world
    /// </summary>
    public readonly int version;

    /// <summary>
    ///     Name of the world
    /// </summary>
    public string Name {
        get => this.TryGetWorldInfo(out var info) ? info.name : "~World";
        set {
            if (this.TryGetWorldInfo(out var info))
                info.name = value;
        }
    }

    /// <summary>
    ///     Returns a copy of all the archetypes in the current world
    /// </summary>
    public Archetype[] GetArchetypes() {
        Archetype[] archetypes;
        if (this.TryGetWorldInfo(out var info)) {
            archetypes = new Archetype[info.ArchetypeCount];
            int count = 0;
            foreach (var arch in info.archetypes)
                if (arch.data != null) {
                    archetypes[count] = arch.data.archetype;
                    count++;
                }
        }
        else {
            archetypes = Array.Empty<Archetype>();
        }
        return archetypes;
    }

    /// <summary>
    ///     Returns a copy of all the entities in the the current world
    /// </summary>
    public Entity[] GetEntities() {
        Entity[] entities;
        if (this.TryGetWorldInfo(out var info)) {
            entities = new Entity[EntityCount];
            int count = 0;
            foreach (var archetype in info.archetypes)
                if (archetype.data != null)
                    for (int e = 0; e < archetype.data.entity_Count; ++e) {
                        entities[count] = archetype.data.entities[e];
                        count++;
                    }
        }
        else {
            entities = Array.Empty<Entity>();
        }
        return entities;
    }

    /// <summary>
    ///     Creates a new world
    /// </summary>
    public static World Create() {
        return Create("World");
    }

    /// <summary>
    ///     Gets world with name, else creates and returns a world with name
    /// </summary>
    public static World GetOrCreate(string name) {
        if (!TryGetWorld(name, out var world))
            return Create(name);
        return world;
    }

    /// <summary>
    ///     Tries to get world with name
    /// </summary>
    /// <param name="name">name of the target world</param>
    /// <param name="target_world">target world</param>
    /// <returns>returns false if not found</returns>
    public static bool TryGetWorld(string name, out World target_world) {
        foreach (var current in GetAll())
            if (current.Name == name) {
                target_world = current;
                return true;
            }
        target_world = default;
        return false;
    }

    /// <summary>
    ///     Creates an new world with Name
    /// </summary>
    public static World Create(string Name) {
        int index = -1;
        for (int i = 0; i < WorldInfo.all.Length; ++i)
            if (WorldInfo.all[i].data == null) {
                index = i;
                break;
            }
        if (index < 0) {
            index = WorldInfo.all.Length;
            Array.Resize(ref WorldInfo.all, index + 4);
        }

        ref var world_data = ref WorldInfo.all[index];
        int version = world_data.version;
        world_data.data = new(Name, new(index, version));
        WorldInfo.world_Count++;
        return world_data.data.world;
    }

    /// <summary>
    ///     Returns true if the world is not null or destroyed
    /// </summary>
    [Pure]
    public bool IsValid() {
        return WorldInfo.all[index].version == version;
    }

    /// <summary>
    ///     Destroys the world along with all it's archetypes and entities
    /// </summary>
    public void Destroy() {
        if (this.TryGetWorldInfo(out var info))
            info.structureEvents.DestroyWorld();
    }

    /// <summary>
    ///     [structural]
    ///     Creates an entity in this world
    /// </summary>
    public Entity CreateEntity() {
        if (this.TryGetWorldInfo(out var info))
            return info.structureEvents.CreateEntity(
                info.GetArchetypeData(info.bufferSignature.Clear()));
        return default;
    }

    /// <summary>
    ///     Returns how many entities are currently in this world
    /// </summary>
    public int EntityCount => this.TryGetWorldInfo(out var info) ? info.entity_Count : 0;

    /// <summary>
    ///     Creates a query that operates on this world
    /// </summary>
    public Query CreateQuery() {
        return new(this);
    }

    /// <summary>
    ///     Tries to get the archetype that matches the supplied TypeSignature.
    ///     Returns false if the world is destroyed or null
    /// </summary>
    public bool TryGetArchetype(out Archetype archetype, TypeSignature signature) {
        if (this.TryGetWorldInfo(out var info)) {
            archetype = info.GetArchetypeData(signature).archetype;
            return true;
        }
        archetype = default;
        return false;
    }

    /// <summary>
    ///     Tries to get an archetype that has the supplied types.
    ///     Returns false if the world is destroyed or null
    /// </summary>
    public bool TryGetArchetype(out Archetype archetype, params Type[] types) {
        return TryGetArchetype(out archetype, new TypeSignature(types));
    }

    /// <summary>
    ///     Tries to get an archetype that has the supplied types.
    ///     Returns false if the world is destroyed or null
    /// </summary>
    public bool TryGetArchetype(out Archetype archetype, IEnumerable<Type> types) {
        return TryGetArchetype(out archetype, new TypeSignature(types));
    }

    /// <summary>
    ///     WorldData is data unique to this world
    ///     Set's the world's data to value.
    /// </summary>
    public World SetData<WorldData>(WorldData world_data) {
        if (this.TryGetWorldInfo(out var info)) {
            var stored = info.GetData<WorldData>();
            stored.assigned_Data = true;
            stored.data = world_data;
        }
        return this;
    }

    /// <summary>
    ///     WorldData is data unique to this world
    ///     Get's a reference to the data which can be assigned.
    ///     Throws an exception if the world is destroyed or null
    /// </summary>
    public ref WorldData GetData<WorldData>() {
        if (this.TryGetWorldInfo(out var info)) {
            var stored = info.GetData<WorldData>();
            stored.assigned_Data = true;
            return ref info.GetData<WorldData>().data;
        }
        throw new($"{this} is invalid, cannot get resource {typeof(WorldData).Name}");
    }

    /// <summary>
    ///     Returns a copy of all the world data currently assigned in the world
    /// </summary>
    public object[] GetAllWorldData() {
        var all = new List<object>();
        if (this.TryGetWorldInfo(out var info))
            foreach (var stored in info.worldData)
                if (stored != null && stored.assigned_Data)
                    all.Add(stored.GetData());
        return all.ToArray();
    }

    /// <summary>
    ///     Retuns a copy of all the Types of world data currently assigned in the world
    /// </summary>
    public Type[] GetAllWorldDataTypes() {
        var all = new List<Type>();
        if (this.TryGetWorldInfo(out var info))
            foreach (var stored in info.worldData)
                if (stored != null && stored.assigned_Data)
                    all.Add(stored.DataType);
        return all.ToArray();
    }

    /// <summary>
    ///     Adds a callback to be invoked whenever an entity sets a component of type
    /// </summary>
    /// <param name="callback">callback to invoke</param>
    /// <param name="register">set true to add callback, false to remove the callback</param>
    public World OnSet<Component>(SetComponentEvent<Component> callback, bool register = true) {
        if (this.TryGetWorldInfo(out var info)) {
            var data = info.GetData<Component>();
            if (register)
                data.set_Callback += callback;
            else data.set_Callback -= callback;
            data.has_Set_Callback = data.set_Callback != null;
        }
        return this;
    }

    /// <summary>
    ///     Adds a callback to be invoked whenever an entity sets a component of type
    /// </summary>
    /// <param name="callback">callback to invoke</param>
    /// <param name="register">set true to add callback, false to remove the callback</param>
    public World OnSet<Component>(SetComponentEventRefOnly<Component> callback,
        bool register = true) {
        if (this.TryGetWorldInfo(out var info)) {
            var data = info.GetData<Component>();
            if (register) {
                if (data.set_Ref_Callback == null)
                    data.set_Callback += data.CallSetRefCallback;
                data.set_Ref_Callback += callback;
            }
            else {
                data.set_Ref_Callback -= callback;
                if (data.set_Ref_Callback == null)
                    data.set_Callback -= data.CallSetRefCallback;
            }

            data.has_Set_Callback = data.set_Callback != null;
        }
        return this;
    }

    /// <summary>
    ///     Adds a callback to be invoked whenever an entity sets a component of type
    /// </summary>
    /// <param name="callback">callback to invoke</param>
    /// <param name="register">set true to add callback, false to remove the callback</param>
    public World OnSet<Component>(SetComponentEventCompOnly<Component> callback,
        bool register = true) {
        if (this.TryGetWorldInfo(out var info)) {
            var data = info.GetData<Component>();
            if (register) {
                if (data.set_Comp_Callback == null)
                    data.set_Callback += data.CallSetCompCallback;
                data.set_Comp_Callback += callback;
            }
            else {
                data.set_Comp_Callback -= callback;
                if (data.set_Comp_Callback == null)
                    data.set_Callback -= data.CallSetCompCallback;
            }

            data.has_Set_Callback = data.set_Callback != null;
        }
        return this;
    }

    /// <summary>
    ///     Adds a callback to be invoked whenever an entity removes a component of type
    /// </summary>
    /// <param name="callback">callback to invoke</param>
    /// <param name="register">set true to add callback, false to remove the callback</param>
    public World OnRemove<Component>(RemoveComponentEvent<Component> callback,
        bool register = true) {
        if (this.TryGetWorldInfo(out var world_info)) {
            var data = world_info.GetData<Component>();
            if (register)
                data.remove_Callback += callback;
            else data.remove_Callback -= callback;
            data.has_Remove_Callback = data.remove_Callback != null;
        }
        return this;
    }

    /// <summary>
    ///     Adds a callback to be invoked whenever an entity removes a component of type
    /// </summary>
    /// <param name="callback">callback to invoke</param>
    /// <param name="register">set true to add callback, false to remove the callback</param>
    public World OnRemove<Component>(RemoveComponentEventCompOnly<Component> callback,
        bool register = true) {
        if (this.TryGetWorldInfo(out var world_info)) {
            var data = world_info.GetData<Component>();
            if (register) {
                if (data.remove_Comp_Callback == null)
                    data.remove_Callback += data.CallRemoveCompCallback;
                data.remove_Comp_Callback += callback;
            }
            else {
                data.remove_Comp_Callback -= callback;
                if (data.remove_Comp_Callback == null)
                    data.remove_Callback -= data.CallRemoveCompCallback;
            }
            data.has_Remove_Callback = data.remove_Callback != null;
        }
        return this;
    }

    /// <summary>
    ///     [structural]
    ///     Resizes all archetype's backing arrays to the minimum power of 2 needed to store their entities
    /// </summary>
    public void ResizeBackingArrays() {
        foreach (var archetype in GetArchetypes())
            archetype.ResizeBackingArrays();
    }

    /// <summary>
    ///     [structural]
    ///     Destroys all archetypes with 0 entities
    /// </summary>
    public void DestroyEmptyArchetypes() {
        foreach (var archetype in GetArchetypes())
            if (archetype.EntityCount == 0)
                archetype.Destroy();
    }

    /// <summary>
    ///     When enabled all structural methods will be cached like they are when iterating a query.
    ///     They will be applied once you disable caching.
    ///     Use to prevent iterator invalidation when manually iterating over entity or component buffers.
    /// </summary>
    public void CacheStructuralEvents(bool enable) {
        if (this.TryGetWorldInfo(out var info))
            info.CacheStructuralChanges = enable;
    }

    /// <summary>
    ///     Returns true if the world is currently caching structural changes
    /// </summary>
    public bool IsCachingStructuralEvents() {
        if (this.TryGetWorldInfo(out var info))
            return info.structureEvents.EnqueueEvents > 0;
        return false;
    }


    public override string ToString() {
        return $"{(IsValid() ? "" : "~")}{Name} {index}.{version}";
    }

    bool IEquatable<World>.Equals(World other) {
        return index == other.index && version == other.version;
    }

    public override int GetHashCode() {
        return index;
    }

    public override bool Equals(object obj) {
        if (obj is World world)
            return world == this;
        return false;
    }

    public static bool operator ==(World a, World b) {
        return a.index == b.index && a.version == b.version;
    }

    public static bool operator !=(World a, World b) {
        return !(a == b);
    }

    public static implicit operator bool(World world) {
        return WorldInfo.all[world.index].version == world.version;
    }

    /// <summary>
    ///     Returns a copy of all active Worlds
    /// </summary>
    public static World[] GetAll() {
        var worlds = new List<World>();
        foreach (var info in WorldInfo.all)
            if (info.data != null)
                worlds.Add(info.data.world);
        return worlds.ToArray();
    }

    /// <summary>
    ///     Tries to get the entity with index.
    ///     returns true if entity is valid
    /// </summary>
    public static bool TryGetEntity(int index, out Entity entity) {
        if (index <= Entities.last) {
            var data = Entities.all[index];
            if (data.arch_Info != null) {
                entity = new(index, data.version);
                return true;
            }
        }
        entity = default;
        return false;
    }

    IEnumerator<Archetype> IEnumerable<Archetype>.GetEnumerator() {
        if (this.TryGetWorldInfo(out var info))
            for (int i = 0; i < info.archetype_Terminating_Index; ++i) {
                var arche_info = info.archetypes[i].data;
                if (arche_info != null)
                    yield return arche_info.archetype;
            }
    }

    IEnumerator IEnumerable.GetEnumerator() {
        if (this.TryGetWorldInfo(out var info))
            for (int i = 0; i < info.archetype_Terminating_Index; ++i) {
                var arche_info = info.archetypes[i].data;
                if (arche_info != null)
                    yield return arche_info.archetype;
            }
    }
}

public delegate void SetComponentEvent<T>(Entity entity, T old_comp, ref T new_comp);

public delegate void SetComponentEventRefOnly<T>(Entity entity, ref T new_comp);

public delegate void SetComponentEventCompOnly<T>(ref T new_comp);

public delegate void RemoveComponentEvent<T>(Entity entity, T component);

public delegate void RemoveComponentEventCompOnly<T>(T component);

public static partial class Extensions
{
    public static bool TryGetWorldInfo(this World world, out WorldInfo info) {
        var data = WorldInfo.all[world.index];
        if (data.version == world.version) {
            info = data.data;
            return true;
        }
        info = default;
        return false;
    }
}