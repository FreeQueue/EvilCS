using System.Collections;
using Serilog.Core;
using Serilog.Events;

namespace Grid.Utils.Playground.Example.Log;

public class LogEnricherExample
{
    public class ThreadIdEnricher : ILogEventEnricher
    {
        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory) {
            logEvent.AddPropertyIfAbsent(propertyFactory.CreateProperty(
                "ThreadId", Environment.CurrentManagedThreadId));
        }
    }
    
    public static void Init() {
        Serilog.Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Verbose()
            .Enrich.With(new ThreadIdEnricher())
            .WriteTo.Console(
                outputTemplate: "{Timestamp:HH:mm} [{Level}] {Message}{NewLine}{Exception}")
            .CreateLogger();
    }

    private static List<List<object>> _list = [
        [1, 2],
        [new Dictionary<int, int> { { 1, 2 }, { 2, 3 } }, new List<int> { 1, 2 }]
    ];

    private static Dictionary<int, Dictionary<int, object>> dic = new() {
        {
            1, new() {
                { 1, 2 }, { 3, 4 }
            }
        }, {
            2, new() {
                { 1, 2 }, { 3, 4 }
            }
        },
    };

    private static IList List => _list;

    public static void Test() {
        Init();
        dic.Log();
    }
}