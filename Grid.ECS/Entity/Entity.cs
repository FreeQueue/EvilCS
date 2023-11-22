namespace Grid.ECS;

public readonly record struct Entity(int Id,int Version=0)
{
	public static implicit operator Entity(int id) => new(id);
	public static implicit operator int(Entity entity) => entity.Id;
	
	
}