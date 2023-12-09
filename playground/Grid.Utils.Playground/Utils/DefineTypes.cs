namespace Grid.Utils.Playground.Utils;

public readonly record struct ReadonlyStruct(int A); 
public record Bar(int A);
public record Foo(int A, Bar B);