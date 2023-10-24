global using SparseIndex=System.Int32;
using System.Collections;

namespace ECS.Storage;

public class SparseArray<T>:IEnumerable<T>
{
    private T?[] _values = new T?[10];
    
    public T? this[SparseIndex index] {
        get => index < _values.Length ? _values[index] : default;
        set {
            if (index >= _values.Length) {
                Array.Resize(ref _values,index+1);
            }
            _values[index] = value;
        }
    }

    public bool Contains(SparseIndex index) {
        return index < _values.Length && _values[index] != null;
    }

    public bool TryGetValue(SparseIndex index, out T value) {
        value = (this[index] ?? default(T))!;
        return this[index] != null;
    }
    
    public T? Remove(SparseIndex index) {
        if (index >= _values.Length) return default;
        var value = _values[index];
        _values[index] = default;
        return value;
    }

    public void Clear() {
        Array.Clear(_values);
    }
    public IEnumerator<T> GetEnumerator() {
        return _values.Cast<T>().TrimNull().GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }
}