using System.Collections;
using System.Diagnostics;
using System.Reflection;

namespace ECS.Util;

public static class LogExtension
{
    public static void Log(this object self) {
        Console.WriteLine(self.Format());
    }

    public static string Format(this object? obj) {
        return obj switch {
            null => "null",
            string s => $"\"{s}\"",
            IDictionary dictionary => dictionary.Format(),
            IList list => list.Format(),
            MethodInfo methodInfo => methodInfo.Format(),
            Type type => type.Format(),
            _ => obj.ToString() ?? string.Empty
        };
    }

    public static string Format(this IDictionary dictionary) {
        var pairs = dictionary.CastToEntries()
            .Select(entry => $"{entry.Key.Format()},{entry.Value.Format()}");
        return $"[{string.Join(',', pairs)}]";
    }

    public static string Format(this IList list) {
        var items = list.Cast<object>().Select(item => item.Format());
        return $"[{string.Join(',', items)}]";
    }

    public static string Format(this MethodInfo methodInfo) {
        if (methodInfo.DeclaringType is { } declaringType)
            return $"{declaringType.Namespace}.{declaringType.Name}.{methodInfo.Name}";
        return methodInfo.Name;
    }

    public static string Format(this Type type) {
        return type.ToString();
    }
}