using System;
namespace SquareAndCross.Interfaces
{
	public interface ICreateDrawingStrategies
	{
		List<IDrawingStrategy> CreateOrGet();
	}
}

