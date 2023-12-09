using BenchmarkDotNet.Running;
using Fast.Activator;
using Fast.Activator.Utils;
using Grid.ECS.Storage;

namespace Grid.ECS.Playground.Benchmark;

public class CreateColumnBenchmark
{
	public static void Run() {
		BenchmarkRunner.Run<CreateColumnBenchmark>();
	}
	
	[Benchmark]
	public object CreateColumn() {
		return new Column<int>();
	}
	
	[Benchmark]
	public object CreateByActivator() {
		return Activator.CreateInstance(typeof(Column<>).MakeGenericType(typeof(int)));
	}
	
	[Benchmark]
	public object CreateByFastActivator() {
		return FastActivator.CreateInstance(typeof(Column<>).MakeGenericType(typeof(int)));
	}
}