namespace CSharpPlayGround.CSharpTest;

public static class TypeTest
{
	public static void Test() {
		Type a = typeof(int);
		Type b = typeof(float);
		Type c = typeof(int);

		int t = 0;
		Type d = t.GetType();

		(a==b).Log();
		(a==c).Log();
		(b==c).Log();
		(a==d).Log();
	}
}