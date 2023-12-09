using System.Diagnostics.CodeAnalysis;

namespace SimpleECS;

/// <summary>
///     Acts as a container of a set of components. Can be filtered by queries to get entities that
///     have specified components.
/// </summary>
public readonly struct Entity : IEquatable<Entity>
{
    internal Entity(int index, int version) {
        this.index = index;
        this.version = version;
    }

    /// <summary>
    ///     the world that the entity belongs to
    /// </summary>
    public World World {
        get {
            ref var info = ref Entities.all[index];
            if (info.version == version)
                return info.world_Info.world;
            return default;
        }
    }

    /// <summary>
    ///     the archetype that the entity belongs to
    /// </summary>
    public Archetype Archetype {
        get {
            ref var info = ref Entities.all[index];
            return info.version == version ? info.arch_Info.archetype : default;
        }
    }

    /// <summary>
    ///     the combination of the index and version act as a unique identifier for the entity
    /// </summary>
    public readonly int index;

    /// <summary>
    ///     the combination of the index and version act as a unique identifier for the entity
    /// </summary>
    public readonly int version;

    /// <summary>
    ///     returns entity's string value if set
    /// </summary>
    public override string ToString() {
        TryGet(out string name);
        if (string.IsNullOrEmpty(name))
            name = IsValid() ? "Entity" : "~Entity";
        return $"{name} {index}.{version}";
    }

    /// <summary>
    ///     returns true if the the entity is not destroyed or null
    /// </summary>
    public bool IsValid() {
        return Entities.all[index].version == version;
    }

    /// <summary>
    ///     returns true if the entity has the component
    /// </summary>
    public bool Has<TComponent>() {
        ref var info = ref Entities.all[index];
        if (info.version == version)
            return info.arch_Info.Has(TypeId<TComponent>.Value);
        return false;
    }

    /// <summary>
    ///     returns true if the entity has the component
    /// </summary>
    public bool Has(Type type) {
        ref var info = ref Entities.all[index];
        if (info.version == version)
            return info.arch_Info.Has(TypeId.Get(type));
        return false;
    }

    /// <summary>
    ///     [structural]
    ///     removes the component from the entity.
    ///     if component was removed will trigger the corresponding on remove component event
    /// </summary>
    public Entity Remove<TComponent>() {
        Entities.all[index].world_Info?.structureEvents.Remove<TComponent>(this);
        return this;
    }

    /// <summary>
    ///     [structural]
    ///     removes the component from the entity.
    ///     if component was removed will trigger the corresponding on remove component event
    /// </summary>
    public Entity Remove(Type type) {
        ref var info = ref Entities.all[index];
        if (info.world_Info != null)
            info.world_Info.GetData(TypeId.Get(type)).Remove(this, info.world_Info.structureEvents);
        return this;
    }

    /// <summary>
    ///     [structural]
    ///     sets the entity's component to value.
    ///     If the entity does not have the component, will move the entity to an archetype that does.
    ///     will trigger the onset component event if component was set
    /// </summary>
    public Entity Set<TComponent>(in TComponent component) {
        Entities.all[index].world_Info?.structureEvents.Set(this, component);
        return this;
    }

    /// <summary>
    ///     [structural]
    ///     sets the entity's component to value.
    ///     If the entity does not have the component, will move the entity to an archetype that does.
    ///     will trigger the onset component event if component was set
    ///     will trigger an exception if component_of_type is not of type
    /// </summary>
    public Entity Set(Type type, object componentOfType) {
        ref var info = ref Entities.all[index];
        if (info.world_Info != null)
            info.world_Info.GetData(TypeId.Get(type))
                .Set(this, componentOfType, info.world_Info.structureEvents);
        return this;
    }

    /// <summary>
    ///     returns true if the entity has component, outputs the component
    /// </summary>
    public bool TryGet<TComponent>([NotNullWhen(true)] out TComponent? component) {
        ref var info = ref Entities.all[index];
        if (info.version == version)
            if (info.arch_Info.TryGetArray<TComponent>(out var buffer)) {
                component = buffer[info.arch_Index];
                return true;
            }
        component = default;
        return false;
    }

    /// <summary>
    ///     returns true if the entity has component, outputs the component
    /// </summary>
    public bool TryGet(Type type, out object component) {
        ref var info = ref Entities.all[index];
        if (info.version == version)
            if (info.arch_Info.TryGetCompBuffer(TypeId.Get(type), out var buffer)) {
                component = buffer.Array[info.arch_Index];
                return true;
            }
        component = default;
        return false;
    }

    /// <summary>
    ///     gets the reference to the component on the entity.
    ///     throws an exception if the entity is invalid or does not have the component
    /// </summary>
    public ref TComponent Get<TComponent>() {
        ref var entityInfo = ref Entities.all[index];
        if (entityInfo.version == version) {
            if (entityInfo.arch_Info.TryGetArray<TComponent>(out var buffer))
                return ref buffer[entityInfo.arch_Index];
            throw new($"{this} does not contain {typeof(TComponent).Name}");
        }
        throw new($"{this} is not a valid entity, cannot get {typeof(TComponent).Name}");
    }

    /// <summary>
    ///     [structural]
    ///     transfers the entity to the target world
    /// </summary>
    public void Transfer(World targetWorld) {
        Entities.all[index].world_Info?.structureEvents.Transfer(this, targetWorld);
    }

    /// <summary>
    ///     [structural]
    ///     destroys the entity
    /// </summary>
    public void Destroy() {
        Entities.all[index].world_Info?.structureEvents.Destroy(this);
    }

    bool IEquatable<Entity>.Equals(Entity other) {
        return index == other.index && version == other.version;
    }

    public override bool Equals(object obj) {
        return obj is Entity e && e == this;
    }

    public static bool operator ==(Entity a, Entity b) {
        return a.index == b.index && a.version == b.version;
    }

    public static bool operator !=(Entity a, Entity b) {
        return !(a == b);
    }

    public override int GetHashCode() {
        return index;
    }

    public static implicit operator bool(Entity entity) {
        return entity.IsValid();
    }

    /// <summary>
    ///     returns a copy of all the entity's components
    /// </summary>
    public object[] GetAllComponents() {
        ref var info = ref Entities.all[index];
        if (info.version == version) return info.arch_Info.GetAllComponents(info.arch_Index);
        return Array.Empty<object>();
    }

    /// <summary>
    ///     returns a copy of all the types of components attached to the entity
    /// </summary>
    public Type[] GetAllComponentTypes() {
        ref var info = ref Entities.all[index];
        if (info.version == version) return info.arch_Info.GetComponentTypes();
        return Type.EmptyTypes;
    }

    /// <summary>
    ///     returns how many components are attached to the entity
    /// </summary>
    public int GetComponentCount() {
        ref var info = ref Entities.all[index];
        if (info.version == version)
            return info.arch_Info.component_Count;
        return 0;
    }
}

public partial class Extensions
{
    /// <summary>
    ///     Sets the value to entity only if entity is valid and has component.
    ///     Does not invoke set callback event
    /// </summary>
    public static void SetDirectNoInvoke(this Entity entity, Type type, in object value) {
        var entityInfo = Entities.all[entity.index];
        if (entityInfo.version == entity.version)
            if (entityInfo.arch_Info.TryGetCompBuffer(TypeId.Get(type), out var buffer))
                buffer.Array[entityInfo.arch_Index] = value;
    }
}