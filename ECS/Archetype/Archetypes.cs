namespace ECS;

public class Archetypes
{
    internal List<Archetype> archetypes=new ();
    internal Dictionary<ArchetypeIdentity, ArchetypeId> archetypeIds = new();
    public ArchetypeId GetIdOrInsert(
        TableId tableId,
        IReadOnlyList<ComponentId> tableComponents
    ) {
        ArchetypeIdentity archetypeIdentity = new(tableComponents);
        if (archetypeIds.TryGetValue(archetypeIdentity, out var id)) {
            return id;
        }
        else {
            id = archetypes.Count;
            archetypes.Add(new ());
            return id;
        }
        

        // let archetypeIdentity = ArchetypeIdentity {
        //     sparse_set_components:
        //     sparseSetComponents.clone().into_boxed_slice(),
        //     table_components:
        //     tableComponents.clone().into_boxed_slice(),
        // }
        // ;
        //
        // let archetypes = &mut self.archetypes;
        // let archetypeComponentCount = &mut self.archetype_component_count;
        // *self
        //     .archetype_ids
        //     .entry(archetypeIdentity)
        //     .or_insert_with(move || {
        //     let id = ArchetypeId::new(archetypes.len());
        //     let tableStart = *archetypeComponentCount;
        //     *archetypeComponentCount += tableComponents.len();
        //     let tableArchetypeComponents =
        //         (tableStart..*archetypeComponentCount).map(ArchetypeComponentId);
        //     let sparseStart = *archetypeComponentCount;
        //     *archetypeComponentCount += sparseSetComponents.len();
        //     let sparseSetArchetypeComponents =
        //         (sparseStart..*archetypeComponentCount).map(ArchetypeComponentId);
        //     archetypes.push(Archetype::new(
        //         id,
        //         tableId,
        //         tableComponents.into_iter().zip(tableArchetypeComponents),
        //         sparseSetComponents
        //             .into_iter()
        //             .zip(sparseSetArchetypeComponents),
        //     ));
        //     id
        // })
    }
}