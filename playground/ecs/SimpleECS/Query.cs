using System.Collections;

namespace SimpleECS;

/// <summary>
///     Operates on all entities that match it's filters
/// </summary>
public partial class Query : IEnumerable<Archetype>
{
    private readonly TypeSignature _include = new();
    private readonly TypeSignature _exclude = new();
    private int _lastLookup, _structureUpdate, _archetypeCount;

    private Archetype[] _matchingArchetypes = new Archetype[8];

    private World _world;

    public Query() {
    }

    public Query(World world) {
        _world = world;
    }

    /// <summary>
    ///     the world the query operates on
    /// </summary>
    public World World {
        get => _world;
        set {
            _structureUpdate = -1;
            _world = value;
        }
    }

    /// <summary>
    ///     the total number of entities that currently match the query
    /// </summary>
    /// <value></value>
    public int EntityCount {
        get {
            int count = 0;
            if (Update(out var world_Info))
                for (int i = 0; i < _archetypeCount; ++i)
                    count += world_Info.archetypes[_matchingArchetypes[i]].data.entity_Count;
            return count;
        }
    }


    IEnumerator<Archetype> IEnumerable<Archetype>.GetEnumerator() {
        if (Update(out var info))
            for (int i = 0; i < _archetypeCount; ++i)
                yield return info.archetypes[_matchingArchetypes[i]].data.archetype;
    }

    IEnumerator IEnumerable.GetEnumerator() {
        if (Update(out var info))
            for (int i = 0; i < _archetypeCount; ++i)
                yield return info.archetypes[_matchingArchetypes[i]].data.archetype;
    }

    public static implicit operator bool(Query query) {
        return query._world;
    }


    /// <summary>
    ///     Returns a copy of all archetypes matching the query
    /// </summary>
    public Archetype[] GetArchetypes() {
        if (Update(out var world_info)) {
            var archetypes = new Archetype[_archetypeCount];
            for (int i = 0; i < _archetypeCount; ++i)
                archetypes[i] = _matchingArchetypes[i];
            return archetypes;
        }
        return Array.Empty<Archetype>();
    }

    /// <summary>
    ///     Returns a copy of all entities matching the query
    /// </summary>
    public Entity[] GetEntities() {
        if (Update(out var world_info)) {
            var entities = new Entity[EntityCount];
            int count = 0;
            for (int i = 0; i < _archetypeCount; ++i)
                if (_matchingArchetypes[i].TryGetArchetypeInfo(out var arch_info))
                    for (int e = 0; e < arch_info.entity_Count; ++e) {
                        entities[count] = arch_info.entities[e];
                        count++;
                    }
            return entities;
        }
        return Array.Empty<Entity>();
    }

    /// <summary>
    ///     filters entities to those that have component
    /// </summary>
    public Query Has<T>() {
        _archetypeCount = 0;
        _structureUpdate = -1;
        _include.Add<T>();
        return this;
    }


    /// <summary>
    ///     filters entities to those that do not have component
    /// </summary>
    public Query Not<T>() {
        _archetypeCount = 0;
        _structureUpdate = -1;
        _exclude.Add<T>();
        return this;
    }

    /// <summary>
    ///     filters entities to those that have components
    /// </summary>
    public Query Has(params Type[] types) {
        _archetypeCount = 0;
        _structureUpdate = -1;
        _include.Add(types);
        return this;
    }

    /// <summary>
    ///     filters entities to those that do not have components
    /// </summary>
    public Query Not(params Type[] types) {
        _archetypeCount = 0;
        _structureUpdate = -1;
        _exclude.Add(types);
        return this;
    }

    /// <summary>
    ///     filters entities to those that have components
    /// </summary>
    public Query Has(IEnumerable<Type> types) {
        if (types != null)
            foreach (var type in types)
                Has(type);
        return this;
    }

    /// <summary>
    ///     filters entities to those that do not have components
    /// </summary>
    public Query Not(IEnumerable<Type> types) {
        if (types != null)
            foreach (var type in types)
                Not(type);
        return this;
    }

    /// <summary>
    ///     clears all previous filters on the query
    /// </summary>
    public Query Clear() {
        _include.Clear();
        _exclude.Clear();
        _archetypeCount = 0;
        _structureUpdate = -1;
        return this;
    }

    /// <summary>
    ///     iterates and peforms action on all entities that match the query
    /// </summary>
    public void Foreach(in Action<Entity> action) {
        if (Update(out var world_info)) {
            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0)
                    for (int e = 0; e < count; ++e)
                        action(entities[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     Destroys matching archetypes along with their entities.
    ///     Most efficient way to destroy entities.
    /// </summary>
    public void DestroyMatching() {
        if (Update(out var world_info))
            foreach (var archetype in GetArchetypes()) // using a copy is safer
                archetype.Destroy();
    }

    // keeps the queried archtypes up to date, return false if the query is not valid
    private bool Update(out WorldInfo world_info) {
        if (_world.TryGetWorldInfo(out world_info)) {
            if (world_info.archetype_Structure_Update_Count != _structureUpdate) {
                _lastLookup = 0;
                _archetypeCount = 0;
                _structureUpdate = world_info.archetype_Structure_Update_Count;
            }
            for (; _lastLookup < world_info.archetype_Terminating_Index; ++_lastLookup) {
                var arch = world_info.archetypes[_lastLookup].data;
                if (arch == null) continue;
                if (arch.signature.HasAll(_include) && !arch.signature.HasAny(_exclude)) {
                    if (_archetypeCount == _matchingArchetypes.Length)
                        Array.Resize(ref _matchingArchetypes, _archetypeCount * 2);
                    _matchingArchetypes[_archetypeCount] = arch.archetype;
                    ++_archetypeCount;
                }
            }
            return true;
        }
        _structureUpdate = -1;
        _archetypeCount = 0;
        return false;
    }

    public override string ToString() {
        return "Query" +
               (_include.Count > 0 ? $" -> Has {_include.TypesToString()}" : "") +
               (_exclude.Count > 0 ? $" -> Not {_exclude.TypesToString()}" : "");
    }

    /// <summary>
    ///     returns all the types in the queries' has filter
    /// </summary>
    public IReadOnlyList<Type> GetHasFilterTypes() {
        return _include.Types;
    }

    /// <summary>
    ///     returns all the types in the queries' not filter
    /// </summary>
    public IReadOnlyList<Type> GetNotFilterTypes() {
        return _exclude.Types;
    }
}