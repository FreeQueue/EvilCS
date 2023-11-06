using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace Grid.ECS.Storage;

public class SparseSet<T> : IDictionary<SparseIndex, T>
{
    private readonly List<SparseIndex> _indices = new();
    private readonly List<T> _dense = new();
    private readonly SparseArray<int> _sparse = new();

    public int Count => _dense.Count;
    public bool IsReadOnly => false;

    public T? this[SparseIndex key] {
        get => _sparse[key] is { } denseIndex ? _dense[denseIndex] : default;
        set {
            if (value == null) {
                Remove(key);
                return;
            }
            if (_sparse[key] is { } denseIndex) {
                _dense[denseIndex] = value;
            }
        }
    }

    public ICollection<SparseIndex> Keys => _indices;
    public ICollection<T> Values => _dense;

    public void Add(SparseIndex index, T value) {
        if (_sparse.TryGetValue(index, out int denseIndex)) {
            _dense[denseIndex] = value;
        }
        else {
            _sparse[index] = _dense.Count;
            _indices.Add(index);
            _dense.Add(value);
        }
    }

    public bool ContainsKey(SparseIndex key) {
        return _sparse.Contains(key);
    }

    public bool Remove(SparseIndex key) {
        if (_sparse.Remove(key) is not { } denseIndex) return false;
        bool isLast = denseIndex == _dense.Count - 1;
        _dense.SwapRemove(denseIndex);
        _indices.SwapRemove(denseIndex);
        if (!isLast) {
            _sparse[_indices[denseIndex]] = denseIndex;
        }
        return true;
    }

    public bool TryGetValue(SparseIndex key,[NotNullWhen(true)] out T? value) {
        if (_sparse[key] is not { } denseIndex) {
            value = default;
            return false;
        }
        value = _dense[denseIndex]!;
        return true;
    }

    public void Clear() {
        _dense.Clear();
        _indices.Clear();
        _sparse.Clear();
    }

    T IDictionary<SparseIndex, T>.this[SparseIndex key] {
        get {
            if (_sparse[key] is { } denseIndex) return _dense[denseIndex];
            throw new KeyNotFoundException($"The key '{key}' not find in SparseSet");
        }
        set {
            if (_sparse[key] is { } denseIndex) _dense[denseIndex] = value;
            throw new KeyNotFoundException($"The key '{key}' not find in SparseSet");
        }
    }

    void ICollection<KeyValuePair<int, T>>.Add(KeyValuePair<SparseIndex, T> item) {
        Add(item.Key, item.Value);
    }

    bool ICollection<KeyValuePair<int, T>>.Contains(KeyValuePair<SparseIndex, T> item) {
        return this[item.Key] is { } value && value.Equals(item.Value);
    }

    void ICollection<KeyValuePair<int, T>>.CopyTo(KeyValuePair<SparseIndex, T>[] array,
        int arrayIndex) {
        using var enumerator = ((IEnumerable<KeyValuePair<int, T>>)this).GetEnumerator();
        for (int i = arrayIndex; i < array.Length; i++) {
            if (!enumerator.MoveNext()) break;
            array[i] = enumerator.Current;
        }
    }

    bool ICollection<KeyValuePair<int, T>>.Remove(KeyValuePair<int, T> item) {
        if (!(this as ICollection<KeyValuePair<int, T>>).Contains(item)) return false;
        return Remove(item.Key);
    }

    IEnumerator<KeyValuePair<SparseIndex, T>> IEnumerable<KeyValuePair<int, T>>.GetEnumerator() {
        return Keys.Zip(Values)
            .Select(tuple => new KeyValuePair<SparseIndex, T>(tuple.First, tuple.Second))
            .GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return ((IEnumerable<KeyValuePair<int, T>>)this).GetEnumerator();
    }
}