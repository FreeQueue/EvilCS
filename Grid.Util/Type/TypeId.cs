using System.Numerics;

namespace Grid.Util;

public readonly struct TypeId: IEquatable<TypeId>, IComparable<TypeId>
{
	private static readonly Dictionary<Type, TypeId> s_newIDs = new();
	private static Type[] s_idToType = new Type[64];
	public static IReadOnlyCollection<Type> AssignedTypes => s_newIDs.Keys;
	public static int AssignedTypesCount => s_newIDs.Count;

	private TypeId(int id) => Id = id;

	public Type Type => s_idToType[Id];
	public int Id { get; }

	public static implicit operator TypeId(Type type) {
		if (s_newIDs.TryGetValue(type, out var id)) return id;
		s_newIDs[type] = id = new(s_newIDs.Count + 1);
		if (id.Id == s_idToType.Length)
			Array.Resize(ref s_idToType, s_idToType.Length * 2);
		s_idToType[id.Id] = type;
		return id;
	}
	
	public bool Equals(TypeId other) {
		return Id == other.Id;
	}

	public override bool Equals(object? obj) {
		return obj is TypeId other && Equals(other);
	}

	public override int GetHashCode() => Id;

	public static bool operator ==(TypeId left, TypeId right) => left.Equals(right);

    public static bool operator !=(TypeId left, TypeId right) => !(left == right);

    public int CompareTo(TypeId other) {
	    return Id.CompareTo(other.Id);
    }
}

public static class TypeExtensions
{
	public static TypeId Id(this Type type) => type;

	public static IEnumerable<TypeId> GetTypeIds(this IEnumerable<Type> types) =>
		types.Select(type => type.Id());
}