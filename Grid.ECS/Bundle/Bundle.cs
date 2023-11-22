using System.Collections.Immutable;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Grid.ECS;

public interface IBundle<TSelf> where TSelf : IBundle<TSelf>
{
	public static TypeSet Types { get; }
	static ImmutableArray<int> offsets { get; }


	static IBundle() {
		var fields=typeof(TSelf).GetFields(BindingFlags.Public | BindingFlags.Instance );
		Array.Sort(fields, (f1, f2) => f1.FieldType.Id().CompareTo(f2.FieldType));
		Types = TypeSet.Get(fields.Select(field => field.FieldType));
		
	}

	// public ref T Get<T>() {
	// 	unsafe {
	// 		IntPtr ptr = GetPointer((TSelf)this, typeof(T)) ??
	// 		             throw new ArgumentException($"Type {typeof(T)} not found in bundle");
	// 		return ref Unsafe.AsRef<T>(ptr.ToPointer());
	// 	}
	// }
}

public static class BundleExtensions
{
	public static TypeSet GetTypes<TSelf>(this IBundle<TSelf> self) where TSelf : IBundle<TSelf> =>
		IBundle<TSelf>.Types;
}

// public record Bundle<T1, T2>(T1 Item1, T2 Item2) : IBundle
// {
// 	static TypeSet IBundle.Types { get; } = TypeSet.Get(typeof(T1), typeof(T2));
// 	public T Get<T>() {
// 		
// 	}
// 	
// 	
// 	
// 	static Bundle() {
// 		if (typeof(T1) == typeof(T2))
// 			throw new ArgumentException($"T1 and T2 must be different types");
// 	}
//
// 	public T1 Item1 { get; init; } = Item1;
//
// 	public static Bundle<T1, T2> Create(T1 item1, T2 item2) => new(item1, item2);
//
// 	public static implicit operator (T1, T2)(Bundle<T1, T2> self) => (self.Item1, self.Item2);
// }

public record TestBundle(int A, int B) : IBundle<TestBundle>
{
	public static void Test() {
		var a = new TestBundle(1, 2);
		var typeSet = a.GetTypes();
		(int c, int d) = a;
		// (int, int) b = a;
	}
}