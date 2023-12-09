namespace Grid.ECS;

public readonly record struct ArchetypeRow(int Index)
{
	public static ArchetypeRow Invalid => -1;
	public static implicit operator ArchetypeRow(int index) => new(index);
	public static implicit operator int(ArchetypeRow self) => self.Index;
}

public readonly record struct ArchetypeId(int Index)
{
	public static ArchetypeId Empty => 0;
	public static ArchetypeId Invalid => -1;
	public static implicit operator ArchetypeId(int index) => new(index);
	public static implicit operator int(ArchetypeId self) => self.Index;
}

public enum ComponentStatus
{
	Add,
	Mutated
}

public readonly struct Archetype
{
}