using System;
using SquareAndCross.Interfaces;

namespace SquareAndCross
{
	public class SquareCollisionDetector : IDetectCollissions
	{
        private readonly ICreateDrawingStrategies factory;

        public SquareCollisionDetector(ICreateDrawingStrategies factory)
		{
            this.factory = factory;
        }

        public bool DoesCollide(int x, int y)
        {
            var hits = 0;
            foreach (var s in factory.CreateOrGet())
            {
                if (s.ShouldDraw(x, y))
                    hits++;
            }
            return hits > 1;
        }
    }
}

