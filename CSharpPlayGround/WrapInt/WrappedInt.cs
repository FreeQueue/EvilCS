using System.Globalization;
using System.Numerics;

namespace CSharpPlayGround.WrapInt;

public record struct WrappedInt(int Value)
{
    public static implicit operator int(WrappedInt self) => self.Value;
    public static implicit operator WrappedInt(int other) => new(other);
}