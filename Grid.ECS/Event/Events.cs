using System.Diagnostics;
using Grid.Util.Collections.Generics;
using Serilog;

namespace Grid.ECS.Event;

public class Events<TEvent> : DoubleBufferQueue<EventInstance<TEvent>> where TEvent : IEvent
{
    public void Send(TEvent e) {
        var id = new EventId<TEvent>(idCounter);
        Log.Verbose("Events<{type}>.Send({@e}) id:{id}", typeof(TEvent), e, id);
        Push(new(id, e));
    }

    public IEnumerable<TEvent> PopAllWithoutId() => PopAll().Select(instance => instance.Event);
}