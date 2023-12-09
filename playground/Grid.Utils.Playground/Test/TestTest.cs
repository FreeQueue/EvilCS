namespace Grid.Utils.Playground.Test;

public class TestTest(ITestOutputHelper output) : OutputTestBase(output)
{
	[Fact]
	public void Test() {
		Logger.Information("Test");
	}
}