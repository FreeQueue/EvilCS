using System.Collections;

namespace ECS.Util;

public static class DictionaryExtension
{
    //为什么需要这样而不能Cast<DictionaryEntry>，Cast内部也是类似实现，只是是用object接收再强转，这毫无道理
    public static IEnumerable<DictionaryEntry> CastToEntries(this IDictionary dictionary) {
        foreach (DictionaryEntry entry in dictionary) {
            yield return entry;
        }
    }
}