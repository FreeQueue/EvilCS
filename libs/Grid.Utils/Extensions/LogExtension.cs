using Serilog.Core;

namespace Grid.Utils;

public static class LogExtension
{
	public static void Log<T>(this T? o, string template = MessageTemplate.Default) =>
		Util.Logger.Information(template, o);
}