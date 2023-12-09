using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;

namespace Grid.Utils;

//决议：由于类型设计的局限，不再考虑ReadOnly集合类型
public static class ListExtension
{
    public static List<T> RemoveRange<T>(this IList<T> self, Range range) {
        (int offset, int length) = range.GetOffsetAndLength(self.Count);
        return self.RemoveRange(offset, length);
    }

    public static List<T> RemoveRange<T>(this IList<T> self, int index, int count) {
        List<T> ret;
        if (self is List<T> list) {
            ret = list.GetRange(index, count);
            list.RemoveRange(index, count);
        }
        else {
            int endIndex = index + count;
            ret = self.GetRange(index, count);
            for (int i = endIndex; i < self.Count; i++) {
                self[i - count] = self[i];
            }
            int newCount = self.Count - count;
            while (self.Count > newCount) {
                self.RemoveLast();
            }
        }
        return ret;
    }


    public static void RemoveLast<T>(this IList<T> self) {
        self.RemoveAt(self.Count - 1);
    }

    public static void Swap<T>(this IList<T> self, int a, int b) {
        (self[b], self[a]) = (self[a], self[b]);
    }

    public static void SwapRemove<T>(this IList<T> self, int index) {
        self.Swap(self.Count - 1, index);
        self.RemoveLast();
    }
}