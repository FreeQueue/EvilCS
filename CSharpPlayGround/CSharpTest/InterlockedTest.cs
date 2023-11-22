using Grid.Util;

namespace CSharpPlayGround;

public static class InterlockedTest
{
    public static void Test() {
        int a= 8;
        int b = 5;
        int c=Interlocked.Add(ref a, b);
        c.Log();
        a.Log();
        
    }
}