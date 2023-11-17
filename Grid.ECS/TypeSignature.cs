using System.Collections;

namespace Grid.ECS;

/// <summary>
///     Aggregates types into a unique signature
/// </summary>
public sealed class TypeSignature : IEquatable<TypeSignature>, IReadOnlyList<Type>
{
    private const int DefaultCapacity = 4;
    private const int GrowCapacity = 4;
    private int[] _typeIds;

    /// <summary>
    ///     number of types that make up the signature
    /// </summary>
    public int Count { get; private set; }

    private TypeSignature(int capacity = DefaultCapacity) {
        _typeIds = new int[capacity];
    }

    public TypeSignature(IEnumerable<Type> types) {
        _typeIds = new int[DefaultCapacity];
        foreach (var type in types)
            Add(type);
    }

    public TypeSignature(TypeSignature signature) {
        Count = signature.Count;
        _typeIds = new int[Count];
        Array.Copy(signature._typeIds, _typeIds, Count);
    }

    public TypeSignature(params Type[] types) {
        _typeIds = new int[types.Length];
        Add(types);
    }

    public TypeSignature Copy(TypeSignature signature) {
        if (_typeIds.Length < signature.Count)
            Array.Resize(ref _typeIds, signature.Count + 1);
        for (int i = 0; i < signature.Count; ++i)
            _typeIds[i] = signature._typeIds[i];
        Count = signature.Count;
        return this;
    }

    public TypeSignature Clear() {
        Count = 0;
        return this;
    }

    #region Add
    internal TypeSignature Add(int typeId) {
        for (int i = 0; i < Count; ++i) {
            // if same exit
            if (_typeIds[i] == typeId) return this;

            // since the hash is generated from this, ordering is important
            if (typeId > _typeIds[i])
                (_typeIds[i], typeId) = (typeId, _typeIds[i]);
        }
        if (Count++ == _typeIds.Length)
            Array.Resize(ref _typeIds, Count + GrowCapacity);
        _typeIds[Count - 1] = typeId;
        return this;
    }

    public TypeSignature Add(params Type[] types) {
        foreach (var type in types)
            Add(type);
        return this;
    }

    public TypeSignature Add(Type type) {
        return Add(TypeId.Get(type));
    }

    public TypeSignature Add<T>() {
        return Add(TypeId<T>.Value);
    }
    #endregion

    #region Remove
    internal TypeSignature Remove(int typeId) {
        bool swap = _typeIds[0] == typeId;
        for (int i = 1; i < Count; ++i)
            if (swap)
                _typeIds[i - 1] = _typeIds[i];
            else
                swap = _typeIds[i] == typeId;
        if (swap)
            Count--;
        return this;
    }

    public TypeSignature Remove(params Type[] types) {
        foreach (var type in types)
            Remove(TypeId.Get(type));
        return this;
    }

    public TypeSignature Remove(Type type) {
        return Remove(TypeId.Get(type));
    }

    public TypeSignature Remove<T>() {
        return Remove(TypeId<T>.Value);
    }
    #endregion

    #region Has
    internal bool Has(int typeid) {
        for (int i = 0; i < Count; ++i)
            if (_typeIds[i] == typeid)
                return true;
        return false;
    }

    public bool Has<T>() {
        return Has(TypeId<T>.Value);
    }

    public bool Has(Type type) {
        return Has(TypeId.Get(type));
    }

    public bool HasAny(TypeSignature other) {
        for (int a = 0; a < Count; ++a)
        for (int b = 0; b < other.Count; ++b)
            if (_typeIds[a] == other._typeIds[b])
                return true;
        return false;
    }

    public bool HasAll(TypeSignature other) {
        for (int a = 0; a < other.Count; ++a) {
            for (int b = 0; b < Count; ++b)
                if (other._typeIds[a] == _typeIds[b])
                    goto next;
            return false;
            next: ;
        }
        return true;
    }
    #endregion

    public override int GetHashCode() {
        const int prime = 53;
        int power = 1;
        int hashCode = 0;

        unchecked {
            for (int i = 0; i < Count; ++i) {
                power *= prime;
                hashCode += _typeIds[i] * power;
            }
        }
        return hashCode;
    }

    public bool Equals(TypeSignature? other) {
        if (other is null) return false;
        return other._typeIds.SequenceEqual(_typeIds);
    }

    public override bool Equals(object? obj) {
        return obj is TypeSignature sig && sig.Equals(this);
    }

    public override string ToString() {
        string sig = "Type Signature [";
        for (int i = 0; i < Count; ++i) {
            var type = TypeId.Get(_typeIds[i]);
            sig += $" {type.Name}";
        }
        sig += "]";

        return sig;
    }

    public string TypesToString() {
        string sig = "[";
        for (int i = 0; i < Count; ++i) {
            var type = TypeId.Get(_typeIds[i]);
            sig += $" {type.Name}";
        }
        sig += "]";

        return sig;
    }

    /// <summary>
    ///     All types that currently make up this signature
    /// </summary>
    public IReadOnlyList<Type> Types => this;

    Type IReadOnlyList<Type>.this[int index] => TypeId.Get(_typeIds[index]);

    IEnumerator<Type> IEnumerable<Type>.GetEnumerator() {
        for (int i = 0; i < Count; ++i)
            yield return TypeId.Get(_typeIds[i]);
    }

    IEnumerator IEnumerable.GetEnumerator() {
        for (int i = 0; i < Count; ++i)
            yield return TypeId.Get(_typeIds[i]);
    }

    int IReadOnlyCollection<Type>.Count => Count;
}