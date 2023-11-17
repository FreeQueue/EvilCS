namespace SimpleECS;

public abstract class WorldData
{
    public bool has_Remove_Callback, has_Set_Callback, assigned_Data;
    public abstract Type DataType { get; }
    public abstract void Set(in Entity entity, in StructureEventHandler handler);
    public abstract void Set(in Entity entity, object component, in StructureEventHandler handler);
    public abstract void Remove(in Entity entity, in StructureEventHandler handler);
    public abstract void InvokeRemoveCallbackAll(in Entity[] entities, in object buffer, int count);
    public abstract void InvokeRemoveCallback(in Entity entity, in object component);

    public abstract object GetData();
}

public sealed class WorldData<T> : WorldData
{
    public T data;
    public RemoveComponentEvent<T> remove_Callback;
    public RemoveComponentEventCompOnly<T> remove_Comp_Callback;
    public SetComponentEvent<T> set_Callback;
    public SetComponentEventCompOnly<T> set_Comp_Callback;

    public readonly Queue<T> set_Queue = new();
    public SetComponentEventRefOnly<T> set_Ref_Callback;

    public override Type DataType => typeof(T);

    public override void Set(in Entity entity, in StructureEventHandler handler) {
        handler.Set(entity, set_Queue.Dequeue());
    }

    public override void Set(in Entity entity, object component, in StructureEventHandler handler) {
        handler.Set(entity, (T)component);
    }

    public override void Remove(in Entity entity, in StructureEventHandler handler) {
        handler.Remove<T>(entity);
    }

    public override void
        InvokeRemoveCallbackAll(in Entity[] entities, in object buffer, int count) {
        var array = (T[])buffer;
        for (int i = 0; i < count; ++i)
            remove_Callback?.Invoke(entities[i], array[i]);
    }

    public override void InvokeRemoveCallback(in Entity entity, in object comp) {
        remove_Callback?.Invoke(entity, (T)comp);
    }


    public void CallSetRefCallback(Entity entity, T old_comp, ref T new_comp) {
        set_Ref_Callback.Invoke(entity, ref new_comp);
    }

    public void CallSetCompCallback(Entity entity, T old_comp, ref T new_comp) {
        set_Comp_Callback.Invoke(ref new_comp);
    }

    public void CallRemoveCompCallback(Entity entity, T component) {
        remove_Comp_Callback.Invoke(component);
    }

    public override object GetData() {
        return data;
    }
}