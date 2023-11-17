namespace SimpleECS;

public class WorldInfo
{
    public static (WorldInfo data, int version)[] all;
    public static int world_Count;

    private bool _cacheStructuralChanges;
    public int archetype_Structure_Update_Count;
    public int archetype_Terminating_Index;

    public (ArchetypeInfo data, int version)[] archetypes = new (ArchetypeInfo, int)[32];

    // just a scratch signature so that I'm not making new ones all the time
    public readonly TypeSignature bufferSignature = new();

    public int entity_Count;

    public readonly Stack<int> freeArchetypes = new();

    public string name;

    public readonly Dictionary<TypeSignature, int> signatureToArchetypeIndex = new();

    /// <summary>
    ///     Handles all structural changes to the ecs world
    /// </summary>
    public StructureEventHandler structureEvents;

    public World world;
    public WorldData[] worldData = new WorldData[32];

    static WorldInfo() {
        all = new (WorldInfo, int)[4];
        // added a version to the 0th index so that a default world will be invalid
        all[0].version = 1; 
    }

    public WorldInfo(string name, World world) {
        this.name = name;
        this.world = world;
        // this is just to prevent default archetype and default entity from being valid
        archetypes[0].version++; 
        structureEvents = new(this);
    }

    public bool CacheStructuralChanges {
        get => _cacheStructuralChanges;
        set {
            structureEvents.EnqueueEvents += value ? 1 : -1;
            _cacheStructuralChanges = value;
        }
    }

    public int ArchetypeCount => archetype_Terminating_Index - freeArchetypes.Count;

    public ArchetypeInfo GetArchetypeData(TypeSignature signature) {
        if (!signatureToArchetypeIndex.TryGetValue(signature, out int index)) {
            if (freeArchetypes.Count > 0) {
                index = freeArchetypes.Pop();
                archetype_Structure_Update_Count++;
            }
            else {
                if (archetype_Terminating_Index == archetypes.Length)
                    Array.Resize(ref archetypes, archetype_Terminating_Index * 2);
                index = archetype_Terminating_Index;
                archetype_Terminating_Index++;
            }
            var sig = new TypeSignature(signature);
            signatureToArchetypeIndex[sig] = index;
            archetypes[index].data = new(this, sig, index, archetypes[index].version);
        }
        return archetypes[index].data;
    }

    public WorldData<T> GetData<T>() {
        int type_id = TypeId<T>.Value;
        if (type_id >= worldData.Length) {
            int size = worldData.Length;
            while (size <= type_id)
                size *= 2;
            Array.Resize(ref worldData, size);
        }
        if (worldData[type_id] == null)
            worldData[type_id] = new WorldData<T>();
        return (WorldData<T>)worldData[type_id];
    }

    public WorldData GetData(int type_id) {
        if (type_id >= worldData.Length) {
            int size = worldData.Length;
            while (size <= type_id)
                size *= 2;
            Array.Resize(ref worldData, size);
        }
        if (worldData[type_id] == null) {
            var type = TypeId.Get(type_id);
            worldData[type_id] =
                (WorldData)Activator.CreateInstance(
                    typeof(WorldData<>).MakeGenericType(type));
        }
        return worldData[type_id];
    }
}