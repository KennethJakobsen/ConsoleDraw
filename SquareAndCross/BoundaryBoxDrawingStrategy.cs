using System;
namespace SquareAndCross
{
	public class BoundaryBoxDrawingStrategy : IDrawingStrategy
	{
        private readonly SquareSize size;

        public BoundaryBoxDrawingStrategy(SquareSize size)
		{
            this.size = size;
        }

        public bool ShouldDraw(int x, int y)
        {
            if (x == 0 || x == size.Size - 1 || y == 0 || y == size.Size - 1)
                return true;
            return false;
        }
    }
}

