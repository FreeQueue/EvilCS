using Serilog.Core;

namespace Grid.Util;

public static class LogExtension
{
    private const string DefaultTemplate = "{o}";
    public static void Log<T>(this T? o, string template = DefaultTemplate) => Serilog.Log.Information(template,o);

    public static void LogVerbose<T>(this T? o, string format = DefaultTemplate) => Serilog.Log.Verbose(format,o);

    public static void LogDebug<T>(this T? o, string format = DefaultTemplate) => Serilog.Log.Debug(format,o);

    public static void LogInformation<T>(this T? o, string format = DefaultTemplate) => Serilog.Log.Information(format,o);

    public static void LogWarning<T>(this T? o, string format = DefaultTemplate) => Serilog.Log.Warning(format,o);

    public static void LogError<T>(this T? o, string format = DefaultTemplate) => Serilog.Log.Error(format,o);

    public static void LogFatal<T>(this T? o, string format = DefaultTemplate) => Serilog.Log.Fatal(format,o);
}