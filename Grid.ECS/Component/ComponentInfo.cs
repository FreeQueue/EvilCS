namespace Grid.ECS;

public enum StorageType
{
	Table,
	Bundle,
	Default=Table,
}

public struct ComponentInfo
{
	public static Dictionary<TypeId,ComponentInfo> infos=new();
	
	public TypeId typeId;
	public StorageType storageType;
	
}