using System.Runtime.CompilerServices;

namespace Grid.Utils.Playground.Example.CSharp;

public class GuidExample
{
	public static void Test() {
		Util.Log.Init<GuidExample>();
		var guid= new Guid();
		guid.Log();
		Unsafe.SizeOf<Guid>().Log();
	}
}