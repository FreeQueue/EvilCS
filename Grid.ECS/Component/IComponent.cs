namespace Grid.ECS;

public interface IComponent
{
    public static bool IsComponent(Type type) {
        // 检查T是否为值类型
        if (type.IsValueType) return false;
        // 检查T是否实现了IComponent<T>
        return (from @interface in type.GetInterfaces()
            where @interface.IsGenericType &&
                  @interface.GetGenericTypeDefinition() == typeof(IComponent<>)
            select @interface.GetGenericArguments()).Any(typeArgs => typeArgs[0] == type);
    }
}

public interface IComponent<T> : IComponent where T : struct, IComponent<T>
{
}

public readonly ref struct Reference<T>
{
    public readonly ref T value;

    public Reference(ref T value) {
        this.value = ref value;
    }

    public static implicit operator T(Reference<T> reference) {
        return reference.value;
    }
}