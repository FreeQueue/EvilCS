namespace Grid.ECS.Storage;

public readonly record struct TableRow(int Index)
{
	public static TableRow Invalid => -1;
	public static implicit operator TableRow(int index) => new(index);
	public static implicit operator int(TableRow self) => self.Index;
}