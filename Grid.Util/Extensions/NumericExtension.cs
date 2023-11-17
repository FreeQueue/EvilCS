using System.Numerics;

namespace Grid.Util;

public static class NumericExtension
{
    public static T Max<T>(this T a, T b) where T : IComparisonOperators<T, T, bool> =>
        a > b ? a : b;

    public static T Min<T>(this T a, T b) where T : IComparisonOperators<T, T, bool> =>
        a < b ? a : b;

    public static T Clamp<T>(this T a, T min, T max) where T : IComparisonOperators<T, T, bool> =>
        a.Max(min).Min(max);
    
    
}