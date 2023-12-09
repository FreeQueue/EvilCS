using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyModel;
using Serilog.Debugging;
using Serilog.Settings.Configuration;

namespace Grid.Utils.Playground.Example.Log;

public class ConfigOutputExample
{
	public static void Test() {
		Console.WriteLine(Util.Configuration.GetDebugView());
		Console.WriteLine(Util.Configuration.GetSection("Log").Exists());
	}

	public static void UtilsLog() {
		Util.Log.Init<ConfigOutputExample>();
		Util.Logger.Information("Test");
		Util.Logger.Error("Test");
		Console.WriteLine("Quit");
	}

	public static void Log() {
		Util.Log.Init<ConfigOutputExample>();
		"Test".Log();
	}

	public static void HowToLoadLogTest() {
		SelfLog.Enable(Console.Error);
		SelfLog.Enable(Console.Out);
		
		Thread.CurrentThread.Name = "Main thread";
			
		var logger = new LoggerConfiguration()
			.ReadFrom.Configuration(Util.Configuration, new ConfigurationReaderOptions(
				DependencyContext.Load(Assembly.GetExecutingAssembly())) {
				SectionName = "Log"
			})
			.CreateLogger();

		logger.ForContext("Log", 15).Information("Test");
		logger.Error("Test");
		Console.WriteLine("Quit");
	}

	public static void BaseLog() {
		var logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
		logger.Information("Test");
		logger.Error("Test");
		Console.WriteLine("Quit");
	}
}