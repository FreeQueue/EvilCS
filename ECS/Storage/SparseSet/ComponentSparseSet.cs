using System.Collections;

namespace ECS.Storage;

public class ComponentSparseSet
{
    private IList dense;
    private List<EntityIndex> entities;
    private SparseArray<int> sparse;
}