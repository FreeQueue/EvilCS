// using System.Diagnostics.CodeAnalysis;
//
// namespace Grid.ECS;
//
// public class Bundle
// {
// 	public static Bundle<T1> Create<T1>(T1 item1) => new(item1);
// }
//
// public abstract class Bundle<TSelf, T1> : Bundle where TSelf : Bundle<TSelf, T1>, new()
// {
// 	public abstract T1 Item1 { get; init; }
//
// 	[MemberNotNull(nameof(Item1))]
// 	public static TSelf Create(T1 item1) => new() {
// 		Item1 = item1
// 	};
//
// 	public T1 Deconstruct() => Item1;
// }
//
// public class BundleImpl<T1> : Bundle<BundleImpl<T1>, T1>
// {
// 	public override T1 Item1 { get; init; }
// }
//
// public record TestBundle : Bundle<TestBundle,int>;