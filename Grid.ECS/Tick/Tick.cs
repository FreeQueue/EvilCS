namespace Grid.ECS;

public readonly record struct Tick(int Value)
{
	public static Tick Zero => new (0);
	public static implicit operator int(Tick self) => self.Value;
	public static Tick operator ++(Tick self) => new(self.Value + 1);
	public static Tick operator --(Tick self) => new(self.Value - 1);
	public static Tick operator +(Tick self, Tick value) => new(self.Value + value.Value);
	public static Tick operator -(Tick self, Tick value) => new(self.Value - value.Value);
	public static bool operator <(Tick self, Tick value) => self.Value < value.Value;
	public static bool operator >(Tick self, Tick value) => self.Value > value.Value;
	public static bool operator <=(Tick self, Tick value) => self.Value <= value.Value;
	public static bool operator >=(Tick self, Tick value) => self.Value >= value.Value;
	public bool Equals(Tick other) => Value == other.Value;
	public override int GetHashCode() => Value;
}