namespace Grid.Utils.Playground.Example.Deprecated;

// public class SparseArray<T> : IEnumerable<T> where T : notnull
// {
//     private T?[] _values = new T?[10];
//     
//     public T? this[int index] {
//         get => index < _values.Length ? _values[index] : default;
//         set {
//             if (index >= _values.Length) {
//                 Array.Resize(ref _values, index + 1);
//             }
//             _values[index] = value;
//         }
//     }
//
//     public bool Contains(int index) {
//         return index < _values.Length && _values[index] != null;
//     }
//
//     public bool TryGetValue(int key, [NotNullWhen(true)] out T value) {
//         ref T valRef = ref FindValue(key);
//         if (!Unsafe.IsNullRef(ref valRef))
//         {
//             value = valRef;
//             return true;
//         }
//
//         value = default;
//         return false;
//     }
//
//     public T? Remove(int index) {
//         if (index >= _values.Length) return default;
//         var value = _values[index];
//         _values[index] = default;
//         return value;
//     }
//
//     public void Clear() {
//         Array.Clear(_values);
//     }
//
//     public IEnumerator<T> GetEnumerator() {
//         return _values.Cast<T>().TrimNull().GetEnumerator();
//     }
//
//     IEnumerator IEnumerable.GetEnumerator() {
//         return GetEnumerator();
//     }
// }
