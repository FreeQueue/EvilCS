using System.Collections;

namespace Grid.ECS.Event;

public class EventReader<TEvent> where TEvent : IEvent
{
    public IEnumerable<EventInstance<TEvent>> events;
    // public IEnumerator<(TEvent e, EventId<TEvent> id)> WithId() {
    //     foreach (var (id,e) in events) {
    //         
    //     }
    // }
    // public IEnumerator<TEvent> WithoutId() {
    // }
}