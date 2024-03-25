using System.Collections;

namespace Grid.Utils.Playground.Deprecated;

public static class WrapTest
{
    class TestList<T>:IWrapList<T> 
    {
        private List<T> _list=new();
        public IList<T> WrappedList => _list;

        public void Add(T item) {
            item.Log();
        }
    }
    
    class TestDictionary<TKey,TValue>:IWrapDictionary<TKey,TValue> where TKey : notnull
    {
        private Dictionary<TKey,TValue> _dictionary=new();
        public IDictionary<TKey, TValue> WrappedDictionary => _dictionary;
    }
    
    interface IHasCollection<out T>:IReadOnlyCollection<T>
    {
        new int Count => 1;
        int IReadOnlyCollection<T>.Count => 0;//无法用new Count取代

        IEnumerator<T> IEnumerable<T>.GetEnumerator() {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            throw new NotImplementedException();
        }
    }

    class HasList : IHasCollection<int>
    {
    
    }

    
    
    public static void Test() {
        var list = new TestList<int> { 1 };
        list.Log();
        IWrapList<int> wrapList = list;
        wrapList.Add(2);
        list.Log();
        wrapList.Log();
    }
}