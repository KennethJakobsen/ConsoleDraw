using System;
using Moq;
using SquareAndCross.Interfaces;

namespace SquareAndCross.Tests
{
    [TestClass]
	public class SquareDrawerTestsSquareCollissionDetectorTests
	{
		IDetectCollissions sut;

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
			sut = new SquareCollisionDetector(factory.Object);
        }

		[TestMethod]
		public void Detects_Collissions_In_Crossing_Lines()
        {
			Assert.IsTrue(sut.DoesCollide(1, 1));
        }

		[TestMethod]
		public void Detects_No_Collissions_where_they_shouldnt_be()
		{
			Assert.IsFalse(sut.DoesCollide(0, 1));
		}
	}
}

