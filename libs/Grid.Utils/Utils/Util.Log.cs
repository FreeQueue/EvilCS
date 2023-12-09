using System.Reflection;
using Microsoft.Extensions.DependencyModel;
using Serilog;
using Serilog.Core;
using Serilog.Settings.Configuration;

namespace Grid.Utils;

partial class Util
{
	public static ILogger Logger {
		get => Log.logger ??= Serilog.Log.Logger;
		set => Log.logger = Serilog.Log.Logger = value;
	}

	public static class Log
	{
		public const string DefaultSection = "Log";
		internal static ILogger? logger;

		private static readonly Dictionary<string, ILoggingFilterSwitch> s_filterSwitches = new();

		public static IReadOnlyDictionary<string, ILoggingFilterSwitch> FilterSwitches =>
			s_filterSwitches;

		private static readonly Dictionary<string, LoggingLevelSwitch> s_levelSwitches = new();

		public static IReadOnlyDictionary<string, LoggingLevelSwitch> LevelSwitches =>
			s_levelSwitches;
		
		/// <summary>
		/// Init contextual logger for a given type.
		/// </summary>
		public static void Init<T>(string sectionName = DefaultSection) {
			Init(DependencyContext.Load(typeof(T).Assembly), sectionName);
			Logger = Logger.ForContext<T>();
		}

		public static void Init(Assembly assembly, string sectionName = DefaultSection) {
			Init(DependencyContext.Load(assembly), sectionName);
		}

		public static void Init(
			DependencyContext? dependencyContext = null,
			string sectionName = DefaultSection
		) {
			ConfigurationReaderOptions readerOptions =
				new(dependencyContext) {
					SectionName = sectionName,
					OnFilterSwitchCreated = (switchName, filterSwitch) =>
						s_filterSwitches[switchName] = filterSwitch,
					OnLevelSwitchCreated = (switchName, levelSwitch) =>
						s_levelSwitches[switchName] = levelSwitch,
				};

			Logger = new LoggerConfiguration()
				.ReadFrom.Configuration(Configuration, readerOptions)
				.CreateLogger();
		}
	}
}