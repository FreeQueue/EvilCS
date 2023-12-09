namespace Grid.ECS;

public enum StorageType
{
	Table,
	Bundle,
	Default=Table,
}

public struct ComponentInfo
{
	internal static Dictionary<TypeId,ComponentInfo> infos=new();
	
	internal TypeId typeId;
	public StorageType storageType;
	
}