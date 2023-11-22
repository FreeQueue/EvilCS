namespace Grid.ECS;

public class BundleBuilder
{
	private TypeSet _typeSet;
	private object[] _objects;

	public static BundleBuilder Create(params object[] objects) {
		var builder = new BundleBuilder();
		builder._typeSet = TypeSet.Get(objects.Select(o => o.GetType()));
		return builder;
	}

	public BundleBuilder Add<T>() => Add(typeof(T), default(T));

	public BundleBuilder Add(Type type, object? value) {
		_typeSet = _typeSet.Add(type);
		
		return this;
	}
}