using Grid.Utils.Collections.Generics;
using Serilog;

namespace Grid.ECS.Event;

public class Events<TEvent> : DoubleBufferQueue<EventInstance<TEvent>> where TEvent : IEvent
{
	public void Send(TEvent e) {
		var id = new EventId<TEvent>(idCounter);
		Log.Verbose("Events<{type}>.Send({@e}) id:{id}", typeof(TEvent), e, id);
		Push(new(id, e));
	}

	public IEnumerable<TEvent> PopAllWithoutId() {
		return PopAll().Select(instance => instance.Event);
	}
}