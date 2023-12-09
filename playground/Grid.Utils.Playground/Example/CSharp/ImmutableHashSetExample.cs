using System.Collections.Immutable;

namespace Grid.Utils.Playground.Example.CSharp;

public static class ImmutableHashSetExample
{
	public static void Test() {
		var a=ImmutableHashSet.Create("A", "B");
		var b=ImmutableHashSet.Create("A", "B");
		(a==b).Log();
		a.GetHashCode().Log();
		b.GetHashCode().Log();

		var c = a.Add("C");
	}

	public static void SortedTest() {
		var a = ImmutableSortedSet.Create(1, 2, 3, 4, 5);
		a.Log();
		var b = a.Add(6);
		b.Log();
		var c = a.Add(6);
		(c==b).Log();
		c.SequenceEqual(b).Log();
		(c.GetHashCode()==b.GetHashCode()).Log();
	}
}