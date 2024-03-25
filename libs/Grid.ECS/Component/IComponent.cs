namespace Grid.ECS;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter| AttributeTargets.Property)]
sealed class DeepCopyAttribute : Attribute
{
	public DeepCopyAttribute() {
		// TODO: Implement code here
		throw new NotImplementedException();
	}
}

public interface IComponent<TSelf> where TSelf : struct,IComponent<TSelf>
{
	
}

public struct ComponentA : IComponent<ComponentA>
{
	[DeepCopy]
	int A;

	[DeepCopy]
	private int B { get; }
}

public record struct ComponentB([DeepCopy] int A) : IComponent<ComponentA>;