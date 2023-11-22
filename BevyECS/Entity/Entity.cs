namespace BevyECS;

public readonly record struct Entity(int Index, int Generation = 0)
{
	public static readonly Entity PlaceHolder = FromRaw(int.MaxValue);

	public static Entity FromRaw(int index) {
		return new(index);
	}

	public ulong ToBit() {
		return ((ulong)Generation << 32) | (uint)Index;
	}

	public static Entity FromBit(ulong bits) {
		int index = (int)(bits & uint.MaxValue);
		int generation = (int)(bits >> 32);
		return new(index, generation);
	}

	public static Entity CreateByIndex(int index) {
		return new(index);
	}

	public static implicit operator int(Entity entity) {
		return entity.Index;
	}
}