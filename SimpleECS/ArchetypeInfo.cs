using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace SimpleECS;

public partial class ArchetypeInfo
{
    public readonly Archetype archetype;
    public readonly int component_Count;
    public readonly CompBufferData[] component_Buffers;
    public Entity[] entities = new Entity[8];


    public int entity_Count;
    public readonly TypeSignature signature;
    public readonly WorldInfo world_Info;

    public ArchetypeInfo(WorldInfo world, TypeSignature signature, int archIndex,
        int archVersion) {
        world_Info = world;
        this.signature = signature;
        archetype = new(world.world, archIndex, archVersion);

        component_Buffers = new CompBufferData[signature.Count == 0 ? 1 : signature.Count];
        component_Count = signature.Count;

        for (int i = 0; i < component_Buffers.Length; ++i)
            component_Buffers[i].next = -1;

        // add components into empty bucket, skip if bucket is occupied
        for (int i = 0; i < component_Count; ++i) {
            var type = signature.Types[i];
            int typeId = TypeId.Get(type);
            int index = typeId % component_Buffers.Length;
            ref var bufferData = ref component_Buffers[index];
            if (bufferData.type_Id == 0) {
                bufferData.type_Id = typeId;
                bufferData.buffer = CreatePool(type);
            }
        }

        // add skipped components into buckets not filled in first pass
        // hopefully this minimizes lookup time
        for (int i = 0; i < component_Count; ++i) {
            var type = signature.Types[i];
            int typeId = TypeId.Get(type);
            if (ContainsType(typeId)) continue;
            int index = GetEmptyIndex(typeId % component_Buffers.Length);
            ref var bufferData = ref component_Buffers[index];
            bufferData.type_Id = typeId;
            bufferData.buffer = CreatePool(type);
        }

        bool ContainsType(int typeId) {
            foreach (var val in component_Buffers)
                if (val.type_Id == typeId)
                    return true;
            return false;
        }

        // if current index is filled, will return an empty index with a way to get to that index from the provided one
        int GetEmptyIndex(int currentIndex) {
            if (component_Buffers[currentIndex].type_Id == 0)
                return currentIndex;

            while (component_Buffers[currentIndex].next >= 0)
                currentIndex = component_Buffers[currentIndex].next;

            for (int i = 0; i < component_Count; ++i)
                if (component_Buffers[i].type_Id == 0) {
                    component_Buffers[currentIndex].next = i;
                    return i;
                }
            throw new("FRAMEWORK BUG: not enough components in archetype");
        }

        CompBuffer CreatePool(Type type) {
            return (Activator.CreateInstance(typeof(CompBuffer<>).MakeGenericType(type)) as
                CompBuffer)!;
        }
    }

    /// <summary>
    ///     resizes all backing arrays to minimum power of 2
    /// </summary>
    public void ResizeBackingArrays() {
        int size = 8;
        while (size <= entity_Count)
            size *= 2;
        Array.Resize(ref entities, size);
        for (int i = 0; i < component_Count; ++i)
            component_Buffers[i].buffer.Resize(size);
    }

    public void EnsureCapacity(int capacity) {
        if (capacity >= entities.Length) {
            int size = entities.Length;
            while (capacity >= size)
                size *= 2;
            Array.Resize(ref entities, size);
            for (int i = 0; i < component_Count; ++i)
                component_Buffers[i].buffer.Resize(size);
        }
    }

    public bool Has(int typeId) {
        var data = component_Buffers[typeId % component_Buffers.Length];
        if (data.type_Id == typeId)
            return true;

        while (data.next >= 0) {
            data = component_Buffers[data.next];
            if (data.type_Id == typeId)
                return true;
        }
        return false;
    }

    public bool TryGetArray<TComponent>([NotNullWhen(true)] out TComponent[]? components) {
        int typeId = TypeId<TComponent>.Value;
        var data = component_Buffers[typeId % component_Buffers.Length];
        if (data.type_Id == typeId) {
            components = (TComponent[])data.buffer.Array;
            return true;
        }
        while (data.next >= 0) {
            data = component_Buffers[data.next];
            if (data.type_Id == typeId) {
                components = (TComponent[])data.buffer.Array;
                return true;
            }
        }
        components = default;
        return false;
    }

    public bool TryGetCompBuffer(int typeId, [NotNullWhen(true)] out CompBuffer? buffer) {
        var data = component_Buffers[typeId % component_Buffers.Length];
        if (data.type_Id == typeId) {
            buffer = data.buffer;
            return true;
        }
        while (data.next >= 0) {
            data = component_Buffers[data.next];
            if (data.type_Id == typeId) {
                buffer = data.buffer;
                return true;
            }
        }
        buffer = default;
        return false;
    }

    public object[] GetAllComponents(int entityArchIndex) {
        object[] components = new object[component_Count];

        for (int i = 0; i < component_Count; ++i)
            components[i] = component_Buffers[i].buffer.Array[entityArchIndex];
        return components;
    }

    public Type[] GetComponentTypes() {
        var components = new Type[component_Count];
        for (int i = 0; i < component_Count; ++i)
            components[i] = TypeId.Get(component_Buffers[i].type_Id);
        return components;
    }
}