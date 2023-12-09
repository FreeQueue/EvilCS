namespace Grid.Utils.Playground.Example.WrapInt;

public record struct WrappedInt(int Value)
{
    public static implicit operator int(WrappedInt self) => self.Value;
    public static implicit operator WrappedInt(int other) => new(other);
}