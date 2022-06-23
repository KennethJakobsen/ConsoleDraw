using System;
namespace SquareAndCross.Tests
{
    [TestClass]
	public class LinearFunctionDrawingStrategyTests
	{
		IDrawingStrategy sut = new LinearFunctionDrawingStrategy(1, 0);

		[TestMethod]
		public void LinearFunction_is_a_line()
        {
			Assert.IsTrue(sut.ShouldDraw(0, 0));
			Assert.IsTrue(sut.ShouldDraw(9, 9));
		}

		[TestMethod]
		public void LinearFunction_does_not_draw_outside_the_line()
		{
			Assert.IsFalse(sut.ShouldDraw(0, 1));
			Assert.IsFalse(sut.ShouldDraw(9, 8));
			

		}
	}
}

