using System;
namespace SquareAndCross
{
	public class SquareSize
	{
        public SquareSize()
        {
            Resize(1);
        }
        public SquareSize(int size)
		{
            Resize(size);
        }

            public int Size { get; private set; }

		public void Resize(int size)
        {
            if (size % 2 == 0)
                throw new ArgumentException("Size can not be an even integer");
            Size = size;
        }
		
    
	}
}

