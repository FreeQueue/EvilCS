using Hocon.Extensions.Configuration;
using Microsoft.Extensions.Configuration;

namespace Grid.Utils;

partial class Util
{
	public static IConfigurationRoot Configuration {
		get => Config.configuration ??= new ConfigurationBuilder()
			.SetBasePath(Directory.GetCurrentDirectory())
			.AddHoconFile(path: Config.DefaultPath, optional: false, reloadOnChange: true)
			.Build();
		private set => Config.configuration = value;
	}

	public static class Config
	{
		public const string DefaultPath = "appconfig.conf";

		internal static IConfigurationRoot? configuration;
	}
}