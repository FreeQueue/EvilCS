namespace Grid.ECS;

[AttributeUsage(AttributeTargets.Struct)]
public class StorageTypeAttribute:Attribute
{
    public StorageType StorageType;
    public StorageTypeAttribute(StorageType storageType) {
        StorageType = storageType;
    }
}