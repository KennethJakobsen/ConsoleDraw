using System;
namespace SquareAndCross
{
	public class LinearFunctionDrawingStrategy : IDrawingStrategy
	{
        private readonly int a;
        private readonly int b;

        public LinearFunctionDrawingStrategy(int a, int b)
		{
            this.a = a;
            this.b = b;
        }

        public bool ShouldDraw(int x, int y)
        {
            if (a * x + b == y)
                return true;
            return false;
        }
    }
}

