using System.Collections;

namespace SimpleECS;

public partial class ArchetypeInfo
{
    public struct CompBufferData
    {
        public int next;
        public int type_Id;
        public CompBuffer buffer;
    }

    public abstract class CompBuffer //handles component data
    {
        public abstract IList Array { get; }
        public abstract void Resize(int capacity);

        /// <summary>
        ///     returns removed component
        /// </summary>
        public abstract object Remove(int entityArchIndex, int last);

        public abstract void Move(int entityArchIndex, int lastEntityIndex,
            ArchetypeInfo targetArchetype, int targetIndex);

        public abstract void Move(int entityArchIndex, int lastEntityIndex, object buffer,
            int targetIndex);
    }

    public sealed class CompBuffer<TComponent> : CompBuffer
    {
        public override IList Array =>components;
        public TComponent[] components = new TComponent[8];

        public override void Resize(int capacity) {
            System.Array.Resize(ref components, capacity);
        }

        public override object Remove(int entityArchIndex, int last) {
            var comp = components[entityArchIndex];
            components[entityArchIndex] = components[last];
            components[last] = default;
            return comp;
        }

        public override void Move(int entityArchIndex, int lastEntityIndex,
            ArchetypeInfo targetArchetype, int targetIndex) {
            if (targetArchetype.TryGetArray<TComponent>(out var targetArray))
                targetArray[targetIndex] = components[entityArchIndex];
            components[entityArchIndex] = components[lastEntityIndex];
            components[lastEntityIndex] = default;
        }

        public override void Move(int entityArchIndex, int lastEntityIndex, object buffer,
            int targetIndex) {
            ((TComponent[])buffer)[targetIndex] = components[entityArchIndex];
            components[entityArchIndex] = components[lastEntityIndex];
            components[lastEntityIndex] = default;
        }
    }
}