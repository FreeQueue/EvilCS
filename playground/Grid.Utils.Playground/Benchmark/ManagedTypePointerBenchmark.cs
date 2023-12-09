using BenchmarkDotNet.Running;
using Grid.Utils.Playground.Utils;

namespace Grid.Utils.Playground.Benchmark;

public unsafe class ManagedTypePointerBenchmark
{
	Foo* _pFoo;
	Bar* _pBar;
	ReadonlyStruct* _pStruct;

	public static void Run() {
		BenchmarkRunner.Run<ManagedTypePointerBenchmark>();
	}
	
	[GlobalSetup]
	public void Setup() {
		var bar = new Bar(2);
		var foo = new Foo(1,bar);
		var s = new ReadonlyStruct(1);
		_pStruct = &s;
		_pBar = &bar;
		_pFoo = &foo;
	}
	
	[Benchmark]
	public Bar BarTest() {
		return *_pBar;
    }
	
	[Benchmark]
	public Foo FooTest() {
		return *_pFoo;
	}
	
	[Benchmark]
	public ReadonlyStruct StructTest() {
		return *_pStruct;
	}
}