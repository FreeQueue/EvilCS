namespace Grid.Utils.Playground.Example.WrapInt;

public class IntVsWrappedIntBenchmark
{
    Dictionary<int,object> _intList=default!;
    Dictionary<WrappedInt,object> _wrappedIntList=default!;

    [Params(100,1000)]
    public int n;

    [GlobalSetup]
    public void GlobalSetup()
    {
        _intList = new ();
        _wrappedIntList = new ();

        for (int i = 0; i < n; i++)
        {
            _intList.Add(i,new());
            _wrappedIntList.Add(i,new());
        }
    }

    [Benchmark(Baseline = true)]
    public object DirectIntAccess()
    {
        return _intList[n / 2];
    }

    [Benchmark]
    public object WrappedIntAccess()
    {
        return _wrappedIntList[n / 2];
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
