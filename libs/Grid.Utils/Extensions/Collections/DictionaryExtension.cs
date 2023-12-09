using System.Collections;
using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;

namespace Grid.Utils;

public static class DictionaryExtension
{
    //为什么需要这样而不能Cast<DictionaryEntry>，Cast内部也是类似实现，只是是用object接收再强转，这毫无道理
    //这可能和具体展开有关，foreach可能会先自动转换为IDictionary
    public static IEnumerable<DictionaryEntry> CastToEntries(this IDictionary dictionary) {
        foreach (DictionaryEntry entry in dictionary) {
            yield return entry;
        }
    }
}