using System.Collections;

namespace Grid.Utils.Playground.Example.Deprecated;

public class Set<T> :IReadOnlyCollection<T>, IEquatable<Set<T>>
{
	private readonly HashSet<T> _data;

	public int Count => _data.Count;

	public Set() {
		_data = [];
	}

	public Set(params T[] data) {
		_data = [..data];
	}

	public Set(IEnumerable<T> data) {
		_data = [..data];
	}

	public Set<T> Copy() => new(_data);

	public Set<T> Add(T item) => new(_data.Append(item));

	public Set<T> Add(params T[] items) => Add(items.AsEnumerable());

	public Set<T> Add(IEnumerable<T> items) => new(_data.Concat(items));

	public Set<T> Remove(T item) {
		HashSet<T> data = [.._data];
		data.Remove(item);
		return new(data);
	}

	public Set<T> Remove(params T[] items) => Remove(items.AsEnumerable());

	public Set<T> Remove(IEnumerable<T> items) {
		HashSet<T> data = [.._data];
		foreach (var item in items)
			data.Remove(item);
		return new(data);
	}
	
	public bool Contains(T item) => _data.Contains(item);
	public bool Contains(params T[] items) => Contains(items.AsEnumerable());
	public bool Contains(IEnumerable<T> items) => items.All(Contains);
	

	public IEnumerator<T> GetEnumerator() {
		return _data.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator() {
		return GetEnumerator();
	}

	public bool Equals(Set<T>? other) {
		return other is not null && _data.SequenceEqual(other._data);
	}

	public static bool operator ==(Set<T>? left, Set<T>? right) {
		return left?.Equals(right) ?? right is null;
	}

	public static bool operator !=(Set<T>? left, Set<T>? right) {
		return !(left == right);
	}

    public override bool Equals(object? obj) => Equals(obj as Set<T>);
    public override int GetHashCode() {
	    return _data.GetHashCode();
    }
}

public class CollectionBuilder<T>
{
	private readonly Set<T> _set = new();

	// public CollectionBuilder<T> Add(T item) {
	// }

	public Set<T> Build() => _set;
}