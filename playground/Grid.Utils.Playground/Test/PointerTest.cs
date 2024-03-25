using FluentAssertions;
using Grid.Utils.Playground.Utils;

namespace Grid.Utils.Playground.Test;

public class PointerTest : OutputTestBase
{
	public PointerTest(ITestOutputHelper helper) : base(helper) {
	}

	[Fact]
	public unsafe void Validate() {
		Bar bar = new Bar(2);
		Bar* pBar = &bar;
		Bar bar2 = *pBar;
		bar2.A.Should().Be(bar.A);
	}
}