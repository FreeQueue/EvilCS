using System.Diagnostics.CodeAnalysis;

namespace Grid.ECS.Storage;

public readonly record struct TableRow(int Index)
{
	public static TableRow Invalid => -1;
	public static implicit operator TableRow(int index) => new(index);
	public static implicit operator int(TableRow self) => self.Index;
}

public readonly record struct TableId(int Index)
{
	public static TableId Empty => 0;
	public static TableId Invalid => -1;
	public static implicit operator TableId(int index) => new(index);
	public static implicit operator int(TableId self) => self.Index;
}

public class Table
{
	private readonly Dictionary<TypeId, Column> _columns = new();
	public List<Entity> Entities { get; } = new();

	public Table(TypeSet typeSet) {
		foreach (var type in typeSet) {
			var typeId = type.Id();
			if (!_columns.ContainsKey(typeId)) {
				_columns[typeId] = Column.Create(type);
			}
		}
	}

	public TableRow Add(Entity entity) {
		Reserve(1);
	}

	public bool HasColumn<T>() => HasColumn(typeof(T));
	public bool HasColumn(Type type) => _columns.ContainsKey(type.Id());

	public Column<T> GetColumn<T>() => (Column<T>)GetColumn(typeof(T));
	public Column GetColumn(Type type) => _columns[type.Id()];

	public bool TryGetColumn<T>([NotNullWhen(true)] out Column<T>? column) {
		if (_columns.TryGetValue(typeof(T).Id(), out var c)) {
			column = (Column<T>)c;
			return true;
		}
		column = default;
		return false;
	}

	public bool TryGetColumn(Type type, [NotNullWhen(true)] out Column? column) {
		if (_columns.TryGetValue(type.Id(), out column)) return true;
		column = default;
		return false;
	}

	public void SwapRemove(TableRow row) {
		foreach (var (typeId, column) in _columns) {
			column.SwapRemove(row);
		}
		Entities.SwapRemove(row);
	}

	public void MoveTo(Table newTable, TableRow row) {
		foreach (var (typeId, column) in _columns) {
			column.MoveTo(newTable, row);
		}
		newTable.Entities[row] = Entities[row];
		Entities.SwapRemove(row);
	}
	
	public void Clear() {
		foreach (var column in _columns.Values) {
			column.Clear();
		}
		Entities.Clear();
	}
}