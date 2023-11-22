using System.Collections;
using System.Collections.Immutable;

namespace Grid.Util;

public sealed class TypeSet : IEquatable<TypeSet>, IReadOnlyCollection<Type>,
	IReadOnlyCollection<TypeId>
{
	public static readonly TypeSet Empty = GetFromSorted(ImmutableArray<TypeId>.Empty);
	private static readonly Dictionary<int, TypeSet> s_typeSets = new();

	public int Count => _sortedTypes.Length;
	private readonly ImmutableArray<TypeId> _sortedTypes;
	private readonly int _hashCode;

	private Dictionary<TypeSet, TypeSet>? _add;
	private Dictionary<TypeSet, TypeSet>? _remove;

	#region Create
	public static TypeSet Get() => Empty;
	public static TypeSet Get(params Type[] types) => Get(types.AsEnumerable());

	public static TypeSet Get(IEnumerable<Type> types) => Get(types.GetTypeIds());

	public static TypeSet Get(IEnumerable<TypeId> typeIds) =>
		GetFromSorted(typeIds.ToImmutableArray());

	//typeIds已经是排好序的
	private static TypeSet GetFromSorted(ImmutableArray<TypeId> sortedTypes) {
		//使用默认的比较器，因为TypeId的比较器是根据Type的Id比较的
		sortedTypes = SortedArray.Distinct(sortedTypes);
		int hashCode = Utils.Hash.Combine(sortedTypes.Select(id => id.Id));
		return s_typeSets.TryGetValue(hashCode, out var typeSet)
			? typeSet
			: new(sortedTypes, hashCode);
	}

	//types已经是排好序的
	private TypeSet(ImmutableArray<TypeId> sortedTypes, int hashCode) {
		_sortedTypes = sortedTypes;
		_hashCode = hashCode;
		s_typeSets.Add(_hashCode, this);
	}
	#endregion

	#region Has
	public bool Has<T>() => Has(typeof(T));
	public bool Has(Type type) => Has(type.Id());
	public bool Has(TypeId id) => _sortedTypes.BinarySearch(id) >= 0;

	public bool HasAny(TypeSet other) => SortedArray.HasAny(_sortedTypes, other._sortedTypes);

	public bool HasAll(TypeSet other) => SortedArray.HasAll(_sortedTypes, other._sortedTypes);
	#endregion

	#region Add
	public TypeSet Add<T>() => Add(typeof(T));
	public TypeSet Add(Type type) => GetFromSorted(SortedArray.Add(_sortedTypes, type));

	public TypeSet Add(params Type[] types) => Add(types.AsEnumerable());

	public TypeSet Add(IEnumerable<Type> types) => Get(types).Add(this);

	public TypeSet Add(TypeSet other) {
		return Equals(other)
			? this
			: GetFromSorted(SortedArray.Merge(_sortedTypes, other._sortedTypes));
	}

	public TypeSet AddAndTrace(TypeSet other) {
		if (Equals(other)) return this;
		_add ??= new();
		if (_add.TryGetValue(other, out var result)) return result;
		result = Add(other);
		_add.Add(other, result);
		return result;
	}
	#endregion

	#region Remove
	public TypeSet Remove<T>() => Remove(typeof(T));

	public TypeSet Remove(Type type) {
		return GetFromSorted(_sortedTypes.Remove(type));
	}

	public TypeSet Remove(params Type[] types) => Remove(types.AsEnumerable());

	public TypeSet Remove(IEnumerable<Type> types) => Remove(Get(types));

	public TypeSet Remove(TypeSet other) {
		return Equals(other)
			? Empty
			: GetFromSorted(SortedArray.Except(_sortedTypes, other._sortedTypes));
	}

	public TypeSet RemoveAndTrace(TypeSet other) {
		if (Equals(other)) return Empty;
		_remove ??= new();
		if (_remove.TryGetValue(other, out var result)) return result;
		result = Remove(other);
		_remove.Add(other, result);
		return result;
	}
	#endregion

	public override int GetHashCode() => _hashCode;

	public override string ToString() =>
		$"{nameof(TypeSet)} [{string.Join(", ", _sortedTypes.Select(id => id.Type.Name))}]";

	IEnumerator IEnumerable.GetEnumerator() {
		return GetEnumerator();
	}

	public bool Equals(TypeSet? other) {
		return other != null && _hashCode == other._hashCode;
	}

	public IEnumerator<Type> GetEnumerator() {
		return _sortedTypes.Select(id => id.Type).GetEnumerator();
	}

	IEnumerator<TypeId> IEnumerable<TypeId>.GetEnumerator() {
		return _sortedTypes.AsEnumerable().GetEnumerator();
	}

	public override bool Equals(object? obj) {
		return obj is TypeSet other && Equals(other);
	}
}