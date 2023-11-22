using System.Collections.Immutable;
using System.Diagnostics;

namespace Grid.Util;

public static class SortedArray
{
	public static bool IsSorted<T>(this ImmutableArray<T> self)
		where T : IComparable<T> {
		for (int i = 1; i < self.Length; i++) {
			if (self[i - 1].CompareTo(self[i]) > 0) return false;
		}
		return true;
	}
	
	[Conditional("DEBUG")]
	internal static void CheckSorted<T>(ImmutableArray<T> self)
		where T : IComparable<T> {
		if (!self.IsSorted())throw new ArgumentException("Array is not sorted.");
	}
	
	public static ImmutableArray<T> Distinct<T>(ImmutableArray<T> self)
		where T : IComparable<T> {
		CheckSorted(self);
		var result = ImmutableArray.CreateBuilder<T>(self.Length);
		for (int i = 0; i < self.Length; i++) {
			if (i == 0 || self[i - 1].CompareTo(self[i]) != 0) result.Add(self[i]);
		}
		return result.ToImmutable();
	}
	
	public static bool HasAny<T>(IEnumerable<T> self, IEnumerable<T> other)
		where T : IComparable<T> {
		using var selfEnumerator = self.GetEnumerator();
		using var otherEnumerator = other.GetEnumerator();
		if (!selfEnumerator.MoveNext() || !otherEnumerator.MoveNext()) return false;
		while (true) {
			switch (selfEnumerator.Current.CompareTo(otherEnumerator.Current)) {
				case 0:
					return true;
				case < 0:
					if (!selfEnumerator.MoveNext()) return false;
					break;
				default:
					if (!otherEnumerator.MoveNext()) return false;
					break;
			}
		}
	}

	/// <summary>
	/// self是否包含other的任意一个元素。
	/// </summary>
	public static bool HasAny<T>(ImmutableArray<T> self, ImmutableArray<T> other)
		where T : IComparable<T> {
		CheckSorted(self);
		CheckSorted(other);
		for (int i = 0, j = 0; i < self.Length && j < other.Length;) {
			switch (self[i].CompareTo(other[j])) {
				case 0:
					return true;
				case < 0:
					i++;
					break;
				default:
					j++;
					break;
			}
		}
		return false;
	}

	public static bool HasAll<T>(IEnumerable<T> self, IEnumerable<T> other)
		where T : IComparable<T> {
		using var selfEnumerator = self.GetEnumerator();
		using var otherEnumerator = other.GetEnumerator();
		if (!selfEnumerator.MoveNext() || !otherEnumerator.MoveNext()) return false;
		while (true) {
			switch (selfEnumerator.Current.CompareTo(otherEnumerator.Current)) {
				case 0:
					if (!otherEnumerator.MoveNext()) return true;
					break;
				case < 0:
					if (!selfEnumerator.MoveNext()) return false;
					break;
				default:
					return false;
			}
		}
	}

	/// <summary>
	/// self是否包含other的所有元素。
	/// self和other都是从小到大排好序的。
	/// 注意，重复元素也会被考虑。
	/// </summary>
	public static bool HasAll<T>(ImmutableArray<T> self, ImmutableArray<T> other)
		where T : IComparable<T> {
		CheckSorted(self);
		CheckSorted(other);
		for (int i = 0, j = 0; i < self.Length && j < other.Length;) {
			switch (self[i].CompareTo(other[j])) {
				case 0:
					i++;
					j++;
					break;
				case < 0:
					i++;
					break;
				default:
					return false;
			}
		}
		return true;
	}

	public static ImmutableArray<T> Merge<T>(ImmutableArray<T> self, ImmutableArray<T> other)
		where T : IComparable<T> {
		CheckSorted(self);
		CheckSorted(other);
		var result = ImmutableArray.CreateBuilder<T>(self.Length + other.Length);
		int i = 0, j = 0;
		for (; i < self.Length && j < other.Length;) {
			switch (self[i].CompareTo(other[j])) {
				case 0:
					result.Add(self[i]);
					i++;
					j++;
					break;
				case < 0:
					result.Add(self[i]);
					i++;
					break;
				default:
					result.Add(other[j]);
					j++;
					break;
			}
		}
		result.AddRange(self[i..]);
		result.AddRange(other[j..]);
		return result.ToImmutable();
	}

	public static ImmutableArray<T> Add<T>(ImmutableArray<T> self, T item)
		where T : IComparable<T> {
		CheckSorted(self);
		var result = ImmutableArray.CreateBuilder<T>(self.Length + 1);
		int i = 0;
		for (; i < self.Length;) {
			if (self[i].CompareTo(item) >= 0) break;
			result.Add(self[i]);
			i++;
		}
		result.Add(item);
		result.AddRange(self[i..]);
		return result.ToImmutable();
	}

	public static ImmutableArray<T> Except<T>(ImmutableArray<T> self,
		ImmutableArray<T> other)
		where T : IComparable<T> {
		CheckSorted(self);
		CheckSorted(other);
		var result = ImmutableArray.CreateBuilder<T>(self.Length);
		int i = 0, j = 0;
		for (; i < self.Length && j < other.Length;) {
			switch (self[i].CompareTo(other[j])) {
				case 0:
					i++;
					j++;
					break;
				case < 0:
					result.Add(self[i]);
					i++;
					break;
				default:
					j++;
					break;
			}
		}
		result.AddRange(self[i..]);
		return result.ToImmutable();
	}
}