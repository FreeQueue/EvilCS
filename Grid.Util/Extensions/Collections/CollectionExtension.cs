namespace Grid.Util;

public static class CollectionExtension
{
    public static List<T> GetRange<T>(this ICollection<T> self, Range range) {
        (int offset, int length) = range.GetOffsetAndLength(self.Count);
        return self.GetRange(offset, length);
    }
}