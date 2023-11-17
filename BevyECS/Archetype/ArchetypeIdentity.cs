global using ArchetypeId=System.Int32;

namespace BevyECS;

public readonly struct ArchetypeIdentity
{
    private readonly IReadOnlyList<ComponentId> _tableComponents;

    public ArchetypeIdentity(IReadOnlyList<ComponentId> tableComponents) {
        _tableComponents = tableComponents;
    }

    public bool Equals(ArchetypeIdentity? other) {
        return other != null && _tableComponents.SequenceEqual(other.Value._tableComponents);
    }
}