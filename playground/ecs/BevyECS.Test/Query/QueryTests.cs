using System.Collections;

namespace BevyECS.Query;

public class QueryTests
{
    record struct A(int Value=0);
    record struct B(int Value=0);
    
    private static Dictionary<Type, IList> dic=new() {
        {typeof(A),new List<A> {
            new(1),new(2),new(3),
        }},
        {typeof(B),new List<B> {
            new(4),new(5),new(6),
        }}
    };
    
    // class Query<T>
    // {
    //     public readonly T test;
    //     Func<T> get= () => {
    //         dic
    //     }
    //     
    //     public IEnumerable<T> Get() {
    //         Span<>
    //     }
    // }
    
    [Fact]
    public void Test() {
        // Query<(Ref<A>, Ref<B>)> query = new();
        // foreach (var (a, b) in query.Get()) {
        //     
        // }
    }
}