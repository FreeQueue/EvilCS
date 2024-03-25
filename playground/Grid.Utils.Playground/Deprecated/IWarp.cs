using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace Grid.Utils.Playground.Deprecated;


//思考：这相当于声明了IHasList，可以处理一些其实不是很常见的需求

//不适用，接口中只能显示实现接口，而显示实现无法直接使用，不够方便
public interface IWrapEnumerable<out T> : IEnumerable<T>
{
    IEnumerable<T> WrappedEnumerable { get; }
    IEnumerator<T> IEnumerable<T>.GetEnumerator() => WrappedEnumerable.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => WrappedEnumerable.GetEnumerator();
}

public static class WrapEnumerableExtension
{
    public static IEnumerator<T> GetEnumerator<T>(this IWrapEnumerable<T> self) => self.WrappedEnumerable.GetEnumerator();
}

public interface IWrapCollection<T> : ICollection<T>, IReadOnlyCollection<T>, IWrapEnumerable<T>
{
    ICollection<T> WrappedCollection { get; }
    IEnumerable<T> IWrapEnumerable<T>.WrappedEnumerable => WrappedCollection;
    void ICollection<T>.Add(T item) => WrappedCollection.Add(item);
    void ICollection<T>.Clear() => WrappedCollection.Clear();
    bool ICollection<T>.Contains(T item) => WrappedCollection.Contains(item);

    void ICollection<T>.CopyTo(T[] array, int arrayIndex) =>
        WrappedCollection.CopyTo(array, arrayIndex);

    bool ICollection<T>.Remove(T item) => WrappedCollection.Remove(item);
    int ICollection<T>.Count => WrappedCollection.Count;
    int IReadOnlyCollection<T>.Count => WrappedCollection.Count;
    bool ICollection<T>.IsReadOnly => WrappedCollection.IsReadOnly;
}

// public static class WrapCollectionExtension
// {
//     public static void Add<T>(T item) => WrappedCollection.Add(item);
//     public static void Clear<T>() => WrappedCollection.Clear();
//     public static bool Contains<T>(T item) => WrappedCollection.Contains(item);
//     public static void CopyTo<T>(T[] array, int arrayIndex) => WrappedCollection.CopyTo(array, arrayIndex);
//     public static bool Remove<T>(T item) => WrappedCollection.Remove(item);
//     public static int  Count<T> => WrappedCollection.Count;
// }

public interface IWrapList<T> : IList<T>, IReadOnlyList<T>, IWrapCollection<T>
{
    IList<T> WrappedList { get; }
    ICollection<T> IWrapCollection<T>.WrappedCollection => WrappedList;
    int IList<T>.IndexOf(T item) => WrappedList.IndexOf(item);
    void IList<T>.Insert(int index, T item) => WrappedList.Insert(index, item);
    void IList<T>.RemoveAt(int index) => WrappedList.RemoveAt(index);

    new T this[int index] {
        get => WrappedList[index];
        set => WrappedList[index] = value;
    }
    
    T IList<T>.this[int index] {
        get => WrappedList[index];
        set => WrappedList[index] = value;
    }
    
    T IReadOnlyList<T>.this[int index] => WrappedList[index];
}

public interface IWrapDictionary<TKey, TValue> : IDictionary<TKey, TValue>,
    IReadOnlyDictionary<TKey, TValue>,
    IWrapCollection<KeyValuePair<TKey, TValue>>
{
    IDictionary<TKey, TValue> WrappedDictionary { get; }

    ICollection<KeyValuePair<TKey, TValue>> IWrapCollection<KeyValuePair<TKey, TValue>>.
        WrappedCollection => WrappedDictionary;

    void IDictionary<TKey, TValue>.Add(TKey key, TValue value) => WrappedDictionary.Add(key, value);
    bool IDictionary<TKey, TValue>.ContainsKey(TKey key) => WrappedDictionary.ContainsKey(key);

    bool IReadOnlyDictionary<TKey, TValue>.ContainsKey(TKey key) =>
        WrappedDictionary.ContainsKey(key);

    bool IDictionary<TKey, TValue>.Remove(TKey key) => WrappedDictionary.Remove(key);

    bool IDictionary<TKey, TValue>.TryGetValue(TKey key,
        [MaybeNullWhen(false)] out TValue value) =>
        WrappedDictionary.TryGetValue(key, out value);

    bool IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey key,
        [MaybeNullWhen(false)] out TValue value) =>
        WrappedDictionary.TryGetValue(key, out value);

    TValue IDictionary<TKey, TValue>.this[TKey key] {
        get => WrappedDictionary[key];
        set => WrappedDictionary[key] = value;
    }

    TValue IReadOnlyDictionary<TKey, TValue>.this[TKey key] => WrappedDictionary[key];

    ICollection<TKey> IDictionary<TKey, TValue>.Keys => WrappedDictionary.Keys;
    IEnumerable<TKey> IReadOnlyDictionary<TKey, TValue>.Keys => WrappedDictionary.Keys;
    ICollection<TValue> IDictionary<TKey, TValue>.Values => WrappedDictionary.Values;
    IEnumerable<TValue> IReadOnlyDictionary<TKey, TValue>.Values => WrappedDictionary.Values;
}