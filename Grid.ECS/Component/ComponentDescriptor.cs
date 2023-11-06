using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Grid.ECS;

public readonly record struct ComponentDescriptor(StorageType StorageType,Type Type, int Size)
{
    public string Name => Type.Name;

    public static ComponentDescriptor Create(Type type) {
#if DEBUG
        if (!IComponent.IsComponent(type))
            throw new InvalidOperationException($"Type '{type.Name}' is not Component");
#endif
        var storageType=type.GetCustomAttribute<StorageTypeAttribute>();
        return new(storageType?.StorageType??StorageType.Table, type, Marshal.SizeOf(type));
    }
    
    public static ComponentDescriptor CreateResource(Type type) {
#if DEBUG
        if (!IResource.IsResource(type))
            throw new InvalidOperationException($"Type '{type.Name}' is not Component");
#endif
        var storageType=type.GetCustomAttribute<StorageTypeAttribute>();
        return new(storageType?.StorageType??StorageType.Table, type, Marshal.SizeOf(type));
    }
}