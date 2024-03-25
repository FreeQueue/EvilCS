// ReSharper disable InconsistentNaming
namespace Grid.ECS.Generator;

public static class Metadata
{
	public static class Namespace
	{
		public const string Root = "Grid";
		public const string Ecs = $"{Root}.ECS";
	}

	public static class Interface
	{
		public const string IBundle = $"{Namespace.Ecs}.IBundle";
	}
}