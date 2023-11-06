namespace Grid.ECS.Event;

public interface IEvent
{
}

public readonly record struct EventId<TEvent>(int Id)
    : IComparable<EventId<TEvent>>
    where TEvent : IEvent
{
    public int CompareTo(EventId<TEvent> other) {
        return Id.CompareTo(other.Id);
    }
}

public readonly record struct EventInstance<TEvent>(EventId<TEvent> EventId, TEvent Event)
    where TEvent : IEvent;