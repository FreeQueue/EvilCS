using Microsoft.Extensions.DependencyModel;
using Serilog;
using Serilog.Settings.Configuration;
using Xunit.Abstractions;

namespace Grid.Utils;

public abstract class OutputTestBase
{
	public const string DefaultSection = "TestLog";
	protected ILogger Logger { get; init; }
	protected OutputTestBase(ITestOutputHelper output,bool read = true) {
		Logger = new LoggerConfiguration()
			.ReadFrom.Configuration(Util.Configuration,
				new ConfigurationReaderOptions(DependencyContext.Load(GetType().Assembly)) {
				SectionName = Util.Log.DefaultSection
			})
			.WriteTo.TestOutput(output,
				outputTemplate: LogTemplate.Default)
			.CreateLogger();
	}
}