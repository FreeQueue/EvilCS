namespace Grid.Utils.Playground.Test;

public class TestTest : OutputTestBase
{
	public TestTest(ITestOutputHelper output) : base(output) {
	}

	[Fact]
	public void Test() {
		Logger.Information("Test");
	}
}