using System;
namespace SquareAndCross
{
	public class SquareDrawer : IDrawASquare
	{
        private readonly Dictionary<string, string> written = new System.Collections.Generic.Dictionary<string, string>();
        private readonly int size;
        private readonly int boundary;

        public SquareDrawer(int size)
		{
            this.size = size;
            this.boundary = size - 1;
        }

        public string Draw(int x, int y)
        {
            var drawStr = " ";

            if (x == 0 || x == boundary || y == 0 || y == boundary || 0 + x == y || boundary - x == y)
                drawStr = "#";
            
            if (x == boundary)
                drawStr += Environment.NewLine;
            
            written.Add($"{x},{y}", drawStr);
            return drawStr;
        }
    }
}

