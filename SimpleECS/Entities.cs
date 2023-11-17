namespace SimpleECS;

public static class Entities
{
    public static EntityInfo[] all;
    public static readonly Queue<int> free;
    public static int last;

    static Entities() {
        all = new EntityInfo[1024];
        free = new(1024);
        all[0].version++;
    }
}