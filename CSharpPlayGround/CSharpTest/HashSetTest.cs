namespace CSharpPlayGround.CSharpTest;

public static class HashSetTest
{
	public static void Test() {
		HashSet<int> a = new() {
			1,5,8
		};
		HashSet<int> b = new() {
			2,5,9
		};
		// a.IntersectWith(b);
		// a.ExceptWith(b);
		a.UnionWith(b);
		DisplaySet(a);
		DisplaySet(b);
	}
	
	public static void DisplaySet(HashSet<int> set) {
		foreach (var item in set)
			Console.Write($"{item} ");
		Console.WriteLine();
	}
}