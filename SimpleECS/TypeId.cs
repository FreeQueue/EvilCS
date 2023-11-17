namespace SimpleECS;

#pragma warning disable
/// <summary>
///     assigns ids to types
/// </summary>
public static class TypeId<T>
{
    public static readonly int Value = TypeId.Get(typeof(T));
}
#pragma warning restore
#pragma warning disable
/// <summary>
///     assigns ids to types
/// </summary>
public static class TypeId // class to map types to ids
{
    private static readonly Dictionary<Type, int> s_newIDs = new();
    private static Type[] s_id_to_type = new Type[64];

    public static Type Get(int type_id) {
        return s_id_to_type[type_id];
    }

    public static int Get(Type type) {
        if (!s_newIDs.TryGetValue(type, out int id)) {
            s_newIDs[type] = id = s_newIDs.Count + 1;
            if (id == s_id_to_type.Length)
                Array.Resize(ref s_id_to_type, s_id_to_type.Length * 2);
            s_id_to_type[id] = type;
        }
        return id;
    }

    public static List<Type> GetAssignedTypes() {
        var list = new List<Type>();
        foreach (var type in s_newIDs)
            list.Add(type.Key);
        return list;
    }
}