namespace Grid.ECS;

public enum ComponentStatus
{
    Add,
    Mutated
}

public record struct Archetype(ArchetypeId id,TableId tableId)
{
    // edges: Edges,
    // entities: Vec<ArchetypeEntity>,
    // components: ImmutableSparseSet<ComponentId, ArchetypeComponentInfo>,

    
}