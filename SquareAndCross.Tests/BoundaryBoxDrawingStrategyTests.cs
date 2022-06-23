namespace SquareAndCross.Tests;

[TestClass]
public class BoundaryBoxDrawingStrategyTests
{
    IDrawingStrategy sut = new BoundaryBoxDrawingStrategy(new SquareSize(11));

    
    [TestMethod]
    public void Is_bounding_box_LargeEnough()
    {
        Assert.IsTrue(sut.ShouldDraw(0, 0));
        Assert.IsTrue(sut.ShouldDraw(0, 10));
        Assert.IsTrue(sut.ShouldDraw(10, 0));
        Assert.IsTrue(sut.ShouldDraw(10, 10));

    }

    [TestMethod]
    public void Bounding_box_is_not_too_large()
    {
        Assert.IsFalse(sut.ShouldDraw(11, 11));
    }
    [TestMethod]
    public void Bounding_box_is_empty()
    {
        Assert.IsFalse(sut.ShouldDraw(1, 1));
        Assert.IsFalse(sut.ShouldDraw(9, 1));
        Assert.IsFalse(sut.ShouldDraw(1, 9));
        Assert.IsFalse(sut.ShouldDraw(9, 9));
    }
}
