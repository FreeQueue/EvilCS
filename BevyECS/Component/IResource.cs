namespace BevyECS;

public interface IResource
{
    public static bool IsResource(Type type) {
        // 检查T是否为值类型
        if (type.IsValueType) return false;
        // 检查T是否实现了IComponent<T>
        return (from @interface in type.GetInterfaces()
            where @interface.IsGenericType &&
                  @interface.GetGenericTypeDefinition() == typeof(IResource<>)
            select @interface.GetGenericArguments()).Any(typeArgs => typeArgs[0] == type);
    }
}

public interface IResource<T>:IResource where T:struct,IResource<T>
{
    
}