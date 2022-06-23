using System;
using SquareAndCross.Interfaces;

namespace SquareAndCross
{
	public class DrawingStrategyFactory : ICreateDrawingStrategies
	{
        private readonly SquareSize size;
        private List<IDrawingStrategy> drawingStrategies;
		public DrawingStrategyFactory(SquareSize size)
		{
            this.size = size;
        }

        public List<IDrawingStrategy> CreateOrGet()
        {
            
                return new List<IDrawingStrategy>()
                {
                    new BoundaryBoxDrawingStrategy(size),
                    new LinearFunctionDrawingStrategy(-1, size.Size - 1),
                    new LinearFunctionDrawingStrategy(1, 0)
                };
        }
    }
}

