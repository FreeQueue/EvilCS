namespace Grid.ECS.Generator;

public static class SyntaxNodeExtensions
{
	public static bool IsClassWithSubtypes(this SyntaxNode node)
		=> node is ClassDeclarationSyntax { BaseList.Types.Count: > 0 };

	// Returns true for structs that implement an interface and records with base types.
	// We only check if a record is a value type later on in the chain because we need a TypeSymbol.
	public static bool IsStructOrRecordWithSubtypes(this SyntaxNode node)
		=> node is
			RecordDeclarationSyntax { BaseList.Types.Count: > 0 } or
			StructDeclarationSyntax { BaseList.Types.Count: > 0 };
    
	public static bool IsStructOrRecord(this SyntaxNode node)
		=> node is
			RecordDeclarationSyntax or
			StructDeclarationSyntax;
	
	
}