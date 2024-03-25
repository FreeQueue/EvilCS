namespace Grid.Utils;

public class TypeSetBuilder
{
	private readonly HashSet<Type> _types;

	public TypeSetBuilder() {
		_types = new();
	}

	public TypeSetBuilder(int capacity) {
		_types = new(capacity);
	}

	public void Add<T>() => Add(typeof(T));
	public void Add(Type type) => _types.Add(type);

	public void Add(IEnumerable<Type> types) {
		foreach (var type in types) {
			_types.Add(type);
		}
	}

	public TypeSet Build() => TypeSet.Get(_types);
}