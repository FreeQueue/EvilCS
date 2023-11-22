global using SparseIndex = System.Int32;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace BevyECS.Storage;

public class SparseArray<T> : IEnumerable<T> where T : struct
{
	private T?[] _values = new T?[10];

	public T? this[SparseIndex index] {
		get => index < _values.Length ? _values[index] : default;
		set {
			if (index >= _values.Length) Array.Resize(ref _values, index + 1);
			_values[index] = value;
		}
	}

	public IEnumerator<T> GetEnumerator() {
		return _values.Cast<T>().TrimNull().GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator() {
		return GetEnumerator();
	}

	public bool Contains(SparseIndex index) {
		return index < _values.Length && _values[index] != null;
	}

	public bool TryGetValue(SparseIndex index, [NotNullWhen(true)] out T value) {
		var i = this[index];
		if (i != null) {
			value = i.Value;
			return true;
		}
		value = default;
		return false;
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
}