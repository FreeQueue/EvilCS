namespace Grid.Utils.Misc;

public struct ValueLazy<T>
	where T : notnull
{
	public ValueLazy(Func<T> factory) {
		_factory = factory;
		_value = default;
	}
	
	private readonly Func<T> _factory;
	public T Value => _value ??= _factory();
	private T? _value = default;
}

public struct NewLazy<T> where T : notnull, new()
{
	public T Value => _value ??= new();
	private T? _value;
}