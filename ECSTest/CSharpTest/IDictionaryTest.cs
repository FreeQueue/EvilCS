using System.Collections;

namespace ECSTest.CSharpTest;

public class MyDictionary<K,V>:IDictionary<K,V>
{
    public IEnumerator<KeyValuePair<K, V>> GetEnumerator() {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }

    public void Add(KeyValuePair<K, V> item) {
        throw new NotImplementedException();
    }

    public void Clear() {
        throw new NotImplementedException();
    }

    public bool Contains(KeyValuePair<K, V> item) {
        throw new NotImplementedException();
    }

    public void CopyTo(KeyValuePair<K, V>[] array, int arrayIndex) {
        throw new NotImplementedException();
    }

    public bool Remove(KeyValuePair<K, V> item) {
        throw new NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public void Add(K key, V value) {
        throw new NotImplementedException();
    }

    public bool ContainsKey(K key) {
        throw new NotImplementedException();
    }

    public bool Remove(K key) {
        throw new NotImplementedException();
    }

    public bool TryGetValue(K key, out V value) {
        throw new NotImplementedException();
    }

    public V this[K key] {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public ICollection<K> Keys { get; }
    public ICollection<V> Values { get; }
}