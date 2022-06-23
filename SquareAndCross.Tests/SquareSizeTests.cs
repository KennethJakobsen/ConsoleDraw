using System;
namespace SquareAndCross.Tests
{
    [TestClass]
	public class SquareSizeTests
	{
        SquareSize sut = new SquareSize();

        [TestMethod]
		public void SquareSize_allows_odd_numbers()
        {
            sut.Resize(3);
        }

        [TestMethod]
        public void SquareSize_does_not_allow_even_numbers()
        {
            Assert.ThrowsException<ArgumentException>(() => sut.Resize(2));
        }
    }
}

