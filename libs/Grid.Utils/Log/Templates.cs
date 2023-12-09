using Serilog;

namespace Grid.Utils;

public static class MessageTemplate
{
	public const string Default = "{o}";
	public const string Destructure = "{@o}";
	public const string ForceString = "{$o}";
}

public static class LogTemplate
{
	public const string Default =
		"[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}";
}