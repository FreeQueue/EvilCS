namespace Grid.ECS.Generator.Bundle;

public static partial class Template
{
	public class Bundle
	{
		public const string template =
			//language=C#
			"""
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
			""";
	}
}