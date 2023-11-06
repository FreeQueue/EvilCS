using BenchmarkDotNet.Attributes;

namespace CSharpPlayGround.WrapInt;

public class IntVsWrappedIntBenchmark
{
    private Dictionary<int,object> intList;
    private Dictionary<WrappedInt,object> wrappedIntList;

    [Params(100,1000)]
    public int n;

    [GlobalSetup]
    public void GlobalSetup()
    {
        intList = new ();
        wrappedIntList = new ();

        for (int i = 0; i < n; i++)
        {
            intList.Add(i,new());
            wrappedIntList.Add(i,new());
        }
    }

    [Benchmark(Baseline = true)]
    public object DirectIntAccess()
    {
        return intList[n / 2];
    }

    [Benchmark]
    public object WrappedIntAccess()
    {
        return wrappedIntList[n / 2];
    }
    
    [Benchmark]
    public void CreateInt()
    {
        for (int i = 0; i < n; i++)
        {
             int value = i;
        }
    }

    [Benchmark]
    public void CreateWrappedInt()
    {
        for (int i = 0; i < n; i++)
        {
            WrappedInt wrappedInt = i;
        }
    }
}
