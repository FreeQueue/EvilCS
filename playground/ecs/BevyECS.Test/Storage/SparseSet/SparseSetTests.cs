using System.Collections;
using Xunit.Abstractions;

namespace BevyECS.Storage;

public class SparseSetTests
{
    private record Foo(int Value);

    private readonly ITestOutputHelper _output;

    public SparseSetTests(ITestOutputHelper output) {
        _output = output;
    }

    [Fact]
    public void Test() {
        var set = new SparseSet<Foo>();
        ICollection<KeyValuePair<int, Foo>> collection = set;

        var e0 = Entity.FromRaw(0);
        var e1 = Entity.FromRaw(1);
        var e2 = Entity.FromRaw(2);
        var e3 = Entity.FromRaw(3);
        var e4 = Entity.FromRaw(4);

        set.Add(e1, new(1));
        set.Add(e2, new(2));
        set.Add(e3, new(3));

        Assert.Null(set[e0]);
        Assert.Equal(set[e1], new(1));
        Assert.Equal(set[e2], new(2));
        Assert.Equal(set[e3], new(3));
        Assert.Null(set[e4]);

        var list=new KeyValuePair<int, Foo>[] {
            new(1, new(1)), new(2, new(2)), new(3, new(3))
        };
        Assert.Equal(set.Values, list.Select(pair => pair.Value));
        Assert.Equal(collection,list);
        var copyList =new KeyValuePair<int, Foo>[3];
        collection.CopyTo(copyList,0);
        Assert.Equal(collection,copyList);
        Assert.Equal(copyList,list);
        
        set.Remove(e2, out var value);
        Assert.Equal(value, new(2));
        set.Remove(e2, out value);
        Assert.Null(value);

        Assert.Null(set[e0]);
        Assert.Equal(set[e1], new(1));
        Assert.Null(set[e2]);
        Assert.Equal(set[e3], new(3));
        Assert.Null(set[e4]);

        set.Remove(e1, out value);
        Assert.Equal(value, new(1));

        Assert.Null(set[e0]);
        Assert.Null(set[e1]);
        Assert.Null(set[e2]);
        Assert.Equal(set[e3], new(3));
        Assert.Null(set[e4]);

        set.Add(e1, new(10));

        Assert.Equal(set[e1], new(10));

        set[e1] = new(11);
        Assert.Equal(set[e1], new(11));

        Assert.True(set.ContainsKey(e1));
    }
}