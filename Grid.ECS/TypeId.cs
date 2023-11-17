namespace Grid.ECS;

public static class TypeId<T>
{
    public static readonly int Value = TypeId.Get(typeof(T));
}

public static class TypeId
{
    private static readonly Dictionary<Type, int> s_newIDs = new();
    private static Type[] s_idToType = new Type[64];
    public static IReadOnlyCollection<Type> AssignedTypes => s_newIDs.Keys;

    public static Type Get(int typeId) {
        return s_idToType[typeId];
    }

    public static int Get(Type type) {
        if (s_newIDs.TryGetValue(type, out int id)) return id;
        s_newIDs[type] = id = s_newIDs.Count + 1;
        if (id == s_idToType.Length)
            Array.Resize(ref s_idToType, s_idToType.Length * 2);
        s_idToType[id] = type;
        return id;
    }
}