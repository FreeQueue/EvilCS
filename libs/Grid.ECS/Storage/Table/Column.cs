using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Grid.ECS.Storage;

public abstract class Column
{
	public int Count => addTicks.Count;

	public int Capacity {
		get => addTicks.Capacity;
		set => Resize(value);
	}

	protected readonly List<Tick> addTicks = [];
	protected readonly List<Tick> changeTicks = [];
	public IReadOnlyList<Tick> AddTicks => addTicks;
	public IReadOnlyList<Tick> ChangeTicks => changeTicks;

	public static Column Create(Type type) =>
		(Column?)Activator.CreateInstance(typeof(Column<>).MakeGenericType(type)) ??
		throw new ($"Failed to create column for type {type}");
	public abstract void MoveTo(Column newColumn, TableRow row);
	protected abstract void Resize(int capacity);
	public abstract void SwapRemove(TableRow row);
	public abstract void Clear();
}

public sealed class Column<T> : Column
{
	private readonly List<T> _data = [];

	public ref T this[TableRow row] => ref CollectionsMarshal.AsSpan(_data)[row];

	public void Add(TableRow row, Tick tick,ref T value) {
		_data.Add(value);
		addTicks.Add(tick);
		changeTicks.Add(tick);
	}

	public void Replace(TableRow row, Tick tick,ref T value) {
		_data[row] = value;
		changeTicks[row] = tick;
	}

	public void ReplaceUntracked(TableRow row,ref T value) {
		_data[row] = value;
	}

	public override void MoveTo(Column newColumn, TableRow row) {
		Debug.Assert(newColumn is Column<T>);
		((Column<T>)newColumn).Add(row, addTicks[row],ref this[row]);
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