using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Grid.Util.Collections.Generics;

/// <summary>
/// 无序的引用列表，删除操作是无序的，可以获取Span,不能保证安全
/// </summary>
/// <typeparam name="T"></typeparam>
public class RefList<T>
{
    public Span<T> AsSpan() => _items.AsSpan();
    
    public Span<T> Slice(int start, int length) => AsSpan().Slice(start, length);

    public void SwapRemove(int index) {
        if (index >= _size)
            throw new ArgumentOutOfRangeException(nameof(index));
        _size--;
        _items[index] = _items[_size];
        if (RuntimeHelpers.IsReferenceOrContainsReferences<T>()) {
            _items[_size] = default!;
        }
        // _version++;
    }
    
    public struct Enumerator
    {
        private readonly RefList<T> _list;
        private int _index;
        // private readonly int _version;

        internal Enumerator(RefList<T> list) {
            _list = list;
            _index = 0;
            // _version = list._version;
        }

        public bool MoveNext() {
            // if (_version != _list._version)
            //     throw new InvalidOperationException();
            if ((uint)_index >= (uint)_list._size) {
                _index = _list._size + 1;
                return false;
            }
            _index++;
            return true;
        }

        public ref T Current => ref _list[_index];

        public void Reset() {
            // if (_version != _list._version)
            //     throw new InvalidOperationException();
            _index = 0;
        }
    }
    
    #region 从System.Collections.Generics.List<T>修改
    private const int DefaultCapacity = 4;

    private T[] _items;
    private int _size;
    // 移除版本安全控制
    // private int _version;
    public int Count => _size;


    public RefList(int capacity=0) {
        _items = capacity == 0 ? Array.Empty<T>() : new T[capacity];
    }

    public int Capacity {
        get => _items.Length;
        set {
            if (value < _size)
                throw new ArgumentOutOfRangeException(nameof(value));
            if (value == _items.Length) return;
            if (value > 0) {
                var newItems = new T[value];
                if (_size > 0) Array.Copy(_items, newItems, _size);
                _items = newItems;
            }
            else _items = Array.Empty<T>();
        }
    }

    public ref T this[int index] => ref _items[index];

    public void Add(T item) {
        // _version++;
        int size = _size;
        if (size < _items.Length) {
            _size = size + 1;
            _items[size] = item;
        }
        else AddWithResize(item);
    }

    private void Grow(int capacity) {
        Debug.Assert(_items.Length < capacity);
        int newCapacity = _items.Length == 0 ? DefaultCapacity : 2 * _items.Length;
        if (newCapacity > Array.MaxLength) newCapacity = Array.MaxLength;
        if (newCapacity < capacity) newCapacity = capacity;
        Capacity = newCapacity;
    }

    private void AddWithResize(T item) {
        Debug.Assert(_size == _items.Length);
        int size = _size;
        Grow(size + 1);
        _size = size + 1;
        _items[size] = item;
    }

    public void Clear() {
        // _version++;
        if (RuntimeHelpers.IsReferenceOrContainsReferences<T>()) {
            int size = _size;
            _size = 0;
            if (size > 0)
                Array.Clear(_items, 0, size);
        }
        else _size = 0;
    }

    public bool Contains(T item) => _size != 0 && IndexOf(item) >= 0;

    public void CopyTo(T[] array, int arrayIndex = 0) {
        Array.Copy(_items, 0, array, arrayIndex, _size);
    }

    public Enumerator GetEnumerator() {
        return new(this);
    }

    public int IndexOf(T item)
        => Array.IndexOf(_items, item, 0, _size);

    public int IndexOf(T item, int index) {
        return Array.IndexOf(_items, item, index, _size - index);
    }
    #endregion
}