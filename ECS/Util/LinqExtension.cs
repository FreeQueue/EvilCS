namespace ECS.Util;

public static class LinqExtension
{
    public static IEnumerable<(TSource value, int index)> Index<TSource>(
        this IEnumerable<TSource> source) {
        return source.Select((value, index) => (value, index));
    }

    public static string JoinWith<T>(this IEnumerable<T> source, char separator) {
        return string.Join(separator, source);
    }

    public static string JoinWith<T>(this IEnumerable<T> source, string? separator) {
        return string.Join(separator, source);
    }

    public static IEnumerable<T> TrimNull<T>(this IEnumerable<T> source) {
        return source.Where(element => element != null);
    }
}