using System.Collections;
using System.Diagnostics.CodeAnalysis;
using IReadOnlyDictionary = System.Collections.Generic.IReadOnlyDictionary<System.Type, object>;

namespace Grid.Utils.Playground.Deprecated;

public interface IReadOnlyTypeValueDictionary : IReadOnlyDictionary
{
	TypeSet TypeSet { get; }
	new object this[Type key] { get; set; }
	public new int Count => TypeSet.Count;

	public bool Has<T>() where T : notnull => Get<T>() != null;
	T? Get<T>() where T : notnull => (T?)this[typeof(T)];
	void Set<T>(T value) where T : notnull => this[typeof(T)] = value;

	public bool TryGetValue<T>([NotNullWhen(true)] out T? value) {
		if (this[typeof(T)] is T t) {
			value = t;
			return true;
		}
		value = default;
		return false;
	}

	object IReadOnlyDictionary.this[Type key] => this[key];
	bool IReadOnlyDictionary.ContainsKey(Type type) => TypeSet.Has(type);
	int IReadOnlyCollection<KeyValuePair<Type, object>>.Count => Count;
	IEnumerable<Type> IReadOnlyDictionary.Keys => TypeSet.Types;

	bool IReadOnlyDictionary.TryGetValue(Type key, [NotNullWhen(true)] out object? value) {
		if (this[key] is { } v) {
			value = v;
			return true;
		}
		value = default;
		return false;
	}

	IEnumerator<KeyValuePair<Type, object>> IEnumerable<KeyValuePair<Type, object>>.
		GetEnumerator() {
		return TypeSet
			.Zip(Values)
			.Select(t =>KeyValuePair.Create(t.Item1, t.Item2))
			.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator() {
		return GetEnumerator();
	}
	
	private static bool CheckType(TypeSet typeSet, object?[] values) {
		if (typeSet.Count != values.Length) return false;
		for (int i = 0; i < typeSet.Count; i++) {
			if (values[i] is not {} value) continue;
			if (value.GetType() != typeSet.TypeIds[i].Type) return false;
		}
		return true;
	}
}
