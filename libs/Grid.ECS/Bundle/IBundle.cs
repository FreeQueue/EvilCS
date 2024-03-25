using System.Collections;

namespace Grid.ECS;

public interface IBundle : IEnumerable<object>
{
	public TypeSet TypeSet { get; }
	public IEnumerable<Type> Keys => TypeSet.Types;
	public IEnumerable<(Type type, object value)> Values => TypeSet.Types.Zip(this);
	//是否应该提供默认实现，还是用编译错误来提醒用户使用生成器？
	IEnumerator<object> IEnumerable<object>.GetEnumerator() {
		throw new NotImplementedException();
	}

	IEnumerator IEnumerable.GetEnumerator() {
		return GetEnumerator();
	}
}

public interface IBundle<TSelf> : IBundle where TSelf : struct, IBundle<TSelf>
{
	public static TypeSet TypeSet { get; protected set; }
	TypeSet IBundle.TypeSet => TypeSet;
}

//使用合适的API，而不是使用复杂的语法糖

// public record struct Bundle<T1, T2>(T1 Item1, T2 Item2) : IBundle<Bundle<T1, T2>>
// 	where T1 : struct
// 	where T2 : struct
// {
// 	static Bundle() {
// 		TypeSetBuilder builder = new();
// 		builder.Add(typeof(T1));
// 		builder.Add(typeof(T2));
// 		IBundle<Bundle<T1, T2>>.TypeSet = builder.Build();
// 	}
//
// 	public IEnumerator<object> GetEnumerator() {
// 		yield return Item1;
// 		yield return Item2;
// 	}
//
// 	public static implicit operator Bundle<T1, T2>((T1, T2) tuple) {
// 		return new(tuple.Item1, tuple.Item2);
// 	}
// }

[Bundle]
partial record struct BundleA(int A, float B);

readonly partial record struct BundleA: IBundle<BundleA>
{
	static BundleA() {
		TypeSetBuilder builder = new();
		builder.Add(typeof(int));
		builder.Add(typeof(float));
		IBundle<BundleA>.TypeSet = builder.Build();
	}

	public IEnumerator<object> GetEnumerator() {
		yield return A;
		yield return B;
	}
}
partial record struct BundleB(BundleA A, int B) : IBundle<BundleB>
{
	static BundleB() {
		TypeSetBuilder builder = new();
		builder.Add(IBundle<BundleA>.TypeSet);
		builder.Add(typeof(float));
		IBundle<BundleB>.TypeSet = builder.Build();
	}

	public IEnumerator<object> GetEnumerator() {
		yield return B;
		yield return A.A;
	}
}