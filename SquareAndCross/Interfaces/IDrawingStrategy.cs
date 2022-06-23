using System;
namespace SquareAndCross
{
	public interface IDrawingStrategy
	{
		bool ShouldDraw(int x, int y);
	}
}

