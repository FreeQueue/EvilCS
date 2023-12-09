using System.Collections.Immutable;
using Grid.Utils.Collections.Generics;

namespace Grid.Utils;

public sealed class TypeSet : IEquatable<TypeSet>
{
	public static readonly TypeSet Empty = GetFromSorted(ImmutableArray<TypeId>.Empty);
	private static readonly Dictionary<int, TypeSet> s_typeSets = new();

	public int Count => TypeIds.Length;
	internal ImmutableArray<TypeId> TypeIds { get; }
	public IEnumerable<Type> Types => TypeIds.Select(id => id.Type);
	private readonly int _hashCode;

	private Dictionary<TypeSet, TypeSet>? _add;
	private Dictionary<TypeSet, TypeSet>? _remove;

	#region Create
	public static TypeSet Get() => Empty;
	public static TypeSet Get(params Type[] types) => Get(types.AsEnumerable());

	public static TypeSet Get(IEnumerable<Type> types) => Get(types.GetTypeIds());

	internal static TypeSet Get(IEnumerable<TypeId> typeIds) {
		var sortedTypeIds = SortedArray.Distinct(typeIds.ToImmutableArray());
		return GetFromSorted(sortedTypeIds);
	}

	//
	internal static TypeSet GetFromSorted(ImmutableArray<TypeId> sortedTypeIds) {
		int hashCode = Util.Hash.Combine(sortedTypeIds.Select(id => id.Id));
		return s_typeSets.TryGetValue(hashCode, out var typeSet)
			? typeSet
			: new(sortedTypeIds, hashCode);
	}

	private TypeSet(ImmutableArray<TypeId> sortedTypeIds, int hashCode) {
		TypeIds = sortedTypeIds;
		_hashCode = hashCode;
		s_typeSets.Add(_hashCode, this);
	}
	#endregion

	#region Has
	public bool Has<T>() => Has(typeof(T));
	public bool Has(Type type) => Has(type.Id());
	internal bool Has(TypeId id) => TypeIds.BinarySearch(id) >= 0;

	public bool HasAny(TypeSet other) => SortedArray.HasAny(TypeIds, other.TypeIds);

	public bool HasAll(TypeSet other) => SortedArray.HasAll(TypeIds, other.TypeIds);
	#endregion

	#region Add
	public TypeSet Add<T>() => Add(typeof(T));

	public TypeSet Add(Type type) =>
		Has(type) ? this : GetFromSorted(SortedArray.Add(TypeIds, type));

	public TypeSet Add(params Type[] types) => Add(types.AsEnumerable());

	public TypeSet Add(IEnumerable<Type> types) => Get(types).Add(this);

	public TypeSet Add(TypeSet other) {
		return Equals(other) || HasAll(other)
			? this
			: GetFromSorted(SortedArray.Merge(TypeIds, other.TypeIds));
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
		return GetFromSorted(TypeIds.Remove(type));
	}

	public TypeSet Remove(params Type[] types) => Remove(types.AsEnumerable());

	public TypeSet Remove(IEnumerable<Type> types) => Remove(Get(types));

	public TypeSet Remove(TypeSet other) {
		return Equals(other)
			? Empty
			: GetFromSorted(SortedArray.Except(TypeIds, other.TypeIds));
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
		$"{nameof(TypeSet)} [{string.Join(", ", TypeIds.Select(id => id.Type.Name))}]";

	public bool Equals(TypeSet? other) {
		return other != null && _hashCode == other._hashCode;
	}

	public override bool Equals(object? obj) {
		return obj is TypeSet other && Equals(other);
	}
}