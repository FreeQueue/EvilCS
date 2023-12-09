using FluentAssertions;
using Grid.Utils.Playground.Utils;

namespace Grid.Utils.Playground.Test;

public class PointerTest(ITestOutputHelper helper) : OutputTestBase(helper)
{
	[Fact]
	public unsafe void Validate() {
		Bar bar = new Bar(2);
		Bar* pBar = &bar;
		Bar bar2 = *pBar;
		bar2.A.Should().Be(bar.A);
	}
}