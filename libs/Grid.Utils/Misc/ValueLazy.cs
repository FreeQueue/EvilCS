namespace Grid.Utils.Misc;

public struct ValueLazy<T>(Func<T> factory)
	where T : notnull
{
	public T Value => _value ??= factory();
	private T? _value = default;
}

public struct NewLazy<T> where T : notnull, new()
{
	public T Value => _value ??= new();
	private T? _value;
}