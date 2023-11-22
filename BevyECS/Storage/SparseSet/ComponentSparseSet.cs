using System.Collections;

namespace BevyECS.Storage;

public class ComponentSparseSet
{
	private IList dense;
	private SparseArray<int> sparse;
#if DEBUG
    private List<Entity> entities;
#elif !DEBUG
	private List<int> entities;
#endif
	// public static ComponentSparseSet Create<T>(ComponentInfo info,int capacity) {
	//     
	// }
}