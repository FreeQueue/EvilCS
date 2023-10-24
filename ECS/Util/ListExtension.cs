using System.Numerics;

namespace ECS.Util;

public static class ListExtension
{
    public static void RemoveLast<T>(this IList<T> self) {
        self.RemoveAt(self.Count-1);
    }
    public static void Swap<T>(this IList<T> self, int a, int b) {
        (self[b], self[a]) = (self[a], self[b]);
    }

    public static void SwapRemove<T>(this IList<T> self, int index) {
        self.Swap(self.Count-1,index);
        self.RemoveLast();
    }
    
    public static int BinarySearch<T>(this IReadOnlyList<T> self, T target)
        where T : IComparable<T> {
        return self.BinarySearch(target, 0, self.Count - 1);
    }

    public static int BinarySearch<T>(this IReadOnlyList<T> self, T target, int low, int high)
        where T : IComparable<T> {
        while (low <= high) {
            int mid = (low + high) >>> 1;
            var midVal = self[mid];
            switch (midVal.CompareTo(target)) {
                case < 0:
                    low = mid + 1;
                    break;
                case > 0:
                    high = mid - 1;
                    break;
                default:
                    return mid; // value found
            }
        }
        return ~low; // value not present
    }
}