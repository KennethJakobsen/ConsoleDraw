using System;
using SquareAndCross.Interfaces;

namespace SquareAndCross
{
	public class SquareDrawer : IDrawASquare
	{
        private readonly SquareSize size;
        private readonly ICreateDrawingStrategies factory;
        private readonly IDetectCollissions collissions;

        public SquareDrawer(SquareSize size, ICreateDrawingStrategies factory, IDetectCollissions collissions)
		{
            this.size = size;
            this.factory = factory;
            this.collissions = collissions;
        }

        public string Draw(int x, int y)
        {
            var drawStr = " ";

            foreach(var strategy in factory.CreateOrGet())
            {
                if (strategy.ShouldDraw(x, y))
                    drawStr = "#";
            }

            if(collissions.DoesCollide(x, y))
                drawStr = "X";

            if (x == size.Size-1)
                drawStr += Environment.NewLine;
            
            return drawStr;
        }
    }
}

