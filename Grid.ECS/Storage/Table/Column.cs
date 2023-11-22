using Grid.Util.Collections.Generics;

namespace Grid.ECS.Storage;

public abstract class Column
{
	public int Count => addTicks.Count;
	public int Capacity {
		get => addTicks.Capacity;
		set => Resize(value);
	}

	protected readonly List<Tick> addTicks = new();
	protected readonly List<Tick> changeTicks = new();
	public IReadOnlyList<Tick> AddTicks => addTicks;
	public IReadOnlyList<Tick> ChangeTicks => changeTicks;
	
	public static Column Create(Type type) =>
		(Column)Activator.CreateInstance(typeof(Column<>).MakeGenericType(type))!;
	
	protected abstract void Resize(int capacity);
	public abstract void SwapRemove(TableRow row);
	public abstract void Clear();
}

public sealed class Column<T> : Column
{
	private readonly RefList<T> _data = new();

	public ref T this[TableRow row] => ref _data[row];

	public void Add(TableRow row, Tick tick, T value) {
		_data.Add(value);
		addTicks.Add(tick);
		changeTicks.Add(tick);
	}

	public void Replace(TableRow row, Tick tick, T value) {
		_data[row] = value;
		changeTicks[row] = tick;
	}

	public void ReplaceUntracked(TableRow row, T value) {
		_data[row] = value;
	}

	protected override void Resize(int capacity) {
		_data.Capacity = capacity;
		addTicks.Capacity = capacity;
		changeTicks.Capacity = capacity;
	}

	public override void SwapRemove(TableRow row) {
		_data.SwapRemove(row);
		addTicks.SwapRemove(row);
		changeTicks.SwapRemove(row);
	}

	public override void Clear() {
		_data.Clear();
		addTicks.Clear();
		changeTicks.Clear();
	}
}