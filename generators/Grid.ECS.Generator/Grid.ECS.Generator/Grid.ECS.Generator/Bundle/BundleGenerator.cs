using System.Collections.Immutable;

namespace Grid.ECS.Generator.Bundle;

[Generator]
public class BundleGenerator : IIncrementalGenerator
{
	public void Initialize(IncrementalGeneratorInitializationContext context) {
		var potentialBundles = context.SyntaxProvider.CreateSyntaxProvider(
			(node, token) => node.IsStructOrRecord(),
			static (c, _) => (StructDeclarationSyntax)c.Node).Collect();

		var provider = context.CompilationProvider.Combine(potentialBundles);

		context.RegisterSourceOutput(provider,
			(c, syntaxNode) => { Execute(c, syntaxNode.Left, syntaxNode.Right); });
	}

	public static void Execute(SourceProductionContext context, Compilation compilation
		, ImmutableArray<StructDeclarationSyntax> potentialBundles) {
		var symbol = 
		if (symbols is null) return;
	}
}