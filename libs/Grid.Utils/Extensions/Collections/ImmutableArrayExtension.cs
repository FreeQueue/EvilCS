using System.Collections.Immutable;

namespace Grid.Utils;

public static class ImmutableArrayExtension
{
	public static ImmutableArray<T> Slice<T>(this ImmutableArray<T> self, Range range) {
		(int offset, int length) = range.GetOffsetAndLength(self.Length);
		return ImmutableArray.Create(self, offset, length);
	}
	
	public static ImmutableArray<T> Slice<T>(this ImmutableArray<T> self, int start, int length) {
		return ImmutableArray.Create(self, start, length);
	}
}