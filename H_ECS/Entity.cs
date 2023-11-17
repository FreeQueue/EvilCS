using Grid.Util;

namespace H_ECS;

public readonly record struct Entity(int Index, int Generation = 0)
{
    public static readonly Entity PlaceHolder = FromRaw(int.MaxValue);

    public static Entity FromRaw(int index) {
        return new(index);
    }

    public long ToBit() {
        return ((long)Generation << 32) | (uint)Index;
    }

    public static Entity FromBit(ulong bits) {
        int index = (int)(bits & int.MaxValue);
        int generation = (int)(bits >> 32);
        return new(index, generation);
    }

    public static Entity CreateByIndex(int index) {
        return new(index);
    }

    public static implicit operator int(Entity entity) {
        return entity.Index;
    }
}

public class Entities
{
    private int freeCursor;
    private int len;
    public List<EntityMeta> meta;
    private List<int> pending;

    public IEnumerable<Entity> ReserveEntities(int count) {
        int start = Interlocked.Add(ref freeCursor, -count);
        int end = start + count;
        var reserveEntities = pending.Range(start.Max(0), end.Max(0))
            .Select(id => new Entity(id, meta[id].Generation));
        if (start < 0) {
            int newIdEnd = meta.Count - start;
            int newIdStart = meta.Count - end.Min(0);
            var newEntities = Enumerable.Range(newIdStart, newIdEnd)
                .Select(id => new Entity(id, 1));
            reserveEntities = reserveEntities.Concat(newEntities);
        }
        return reserveEntities;
    }

    public Entity ReserveEntity() {
        int n = Interlocked.Decrement(ref freeCursor);
        if (n >= 0) return new(pending[n], meta[pending[n]].Generation);
        return new(meta.Count - n + 1, 1);
    }
}

public class EntityReserver
{
    private Entities _entities;
    // public void ReserveEntity();
}

public record struct EntityMeta(int Generation, Location Location);

public record struct Location(int Archetype, int Index);

public record struct NoSuchEntity;