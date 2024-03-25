// ReSharper disable InconsistentNaming

namespace Grid.ECS.Generator;

public record struct Symbols(
	INamedTypeSymbol IBundle)
{
	public static Symbols? FromCompilation(Compilation compilation) {
		var iBundle = compilation.GetTypeByMetadataName(Metadata.Interface.IBundle);
		if (iBundle is null) return null;
		return new Symbols(iBundle);
	}
}