using System.Diagnostics;
using System.Runtime.CompilerServices;


namespace Grid.Utils.Collections.Generics;

public class DoubleBufferQueue<T>
{
    /// 请注意，a.startEventCount + a.Count 应始终 === b.startEventCount。
    protected Buffer oldBuffer = new();

    /// Holds the newer items.
    protected Buffer newBuffer = new();

    protected int idCounter;
    public int Count => oldBuffer.items.Count + newBuffer.items.Count;
    public int OldestId => oldBuffer.startId;
    public IEnumerable<T> Old => oldBuffer.items;
    public IEnumerable<T> New => newBuffer.items;

    public T this[int id] {
        get {
            var buffer = GetBuffer(id);
            int index = id - buffer.startId;
            var item = buffer.items[index];
            return item;
        }
    }

    public void Push(T e) {
        newBuffer.items.Add(e);
        idCounter++;
    }

    public void Swap() {
        (oldBuffer, newBuffer) = (newBuffer, oldBuffer);
        newBuffer.items.Clear();
        newBuffer.startId = idCounter;
        Debug.Assert(oldBuffer.startId + oldBuffer.items.Count ==
                     newBuffer.startId);
    }

    public void Clear() {
        oldBuffer.startId = idCounter;
        newBuffer.startId = idCounter;
        oldBuffer.items.Clear();
        newBuffer.items.Clear();
    }


    public IEnumerable<T> PopAll() {
        var oldItems = oldBuffer.items.ToArray();
        var newItems = newBuffer.items.ToArray();
        Clear();
        return Iter();
        IEnumerable<T> Iter() {
            foreach (var item in oldItems) {
                yield return item;
            }
            foreach (var item in newItems) {
                yield return item;
            }
        }
    }
    
    protected Buffer GetBuffer(int id) {
        if (id < OldestId)
            throw new ArgumentOutOfRangeException(nameof(id), id, "id已过期");
        return id < newBuffer.startId ? oldBuffer : newBuffer;
    }

    protected struct Buffer
    {
        public int startId;
        public readonly List<T> items;

        public Buffer() {
            startId = 0;
            items = new();
        }

        public Buffer(int startId, int capacity) {
            this.startId = startId;
            items = new(capacity);
        }
    }
}