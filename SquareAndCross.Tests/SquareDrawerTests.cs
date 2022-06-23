using System;
using Moq;
using SquareAndCross.Interfaces;

namespace SquareAndCross.Tests
{
    [TestClass]
	public class SquareDrawerTests
	{
		IDrawASquare sut;

        [TestInitialize]
		public void Setup()
        {
			var st1 = new Mock<IDrawingStrategy>();
			st1.Setup(d => d.ShouldDraw(1, 1)).Returns(() => true);

			var st2 = new Mock<IDrawingStrategy>();
			st2.Setup(d => d.ShouldDraw(1, 1)).Returns(() => true);

			var factory = new Mock<ICreateDrawingStrategies>();
			factory.Setup(f => f.CreateOrGet()).Returns(() =>
			{
				return new List<IDrawingStrategy>
				{
					st1.Object,
					st2.Object
				};
			});
			var colis = new Mock<IDetectCollissions>();
			colis.Setup(c => c.DoesCollide(1, 1)).Returns(() => true);
			colis.Setup(c => c.DoesCollide(0, 1)).Returns(() => false);

			sut = new SquareDrawer(new SquareSize(3), factory.Object, colis.Object);
        }

		[TestMethod]
		public void Draws_an_x_when_colission_is_detected()
        {
			Assert.IsTrue(sut.Draw(1,1) == "X");
        }

		[TestMethod]
		public void Does_not_draw_an_x_outside_of_collissions()
		{
			Assert.IsFalse(sut.Draw(0, 1) == "X");
		}
	}
}

