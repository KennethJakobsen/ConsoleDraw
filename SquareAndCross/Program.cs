using LightInject;
using SquareAndCross;
using SquareAndCross.Interfaces;

var size = new SquareSize();

var container = new ServiceContainer();
container.Register<ICreateDrawingStrategies, DrawingStrategyFactory>();
container.RegisterInstance(size);
container.Register<IDetectCollissions, SquareCollisionDetector>();
container.Register<IDrawASquare, SquareDrawer>();

var drawer = container.GetInstance<IDrawASquare>();

while (true)
{
    Console.WriteLine("Skriv størrelsen på kvadratet: ");
    if (!int.TryParse(Console.ReadLine(), out int sqSize))
    {
        Console.WriteLine("Indtastede er ikke et tal, prøv igen!");
        continue;
    }

    try
    {
        size.Resize(sqSize);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
        continue;
    }

    for (var y = 0; y < size.Size; y++)
    {
        for (var x = 0; x < size.Size; x++)
        {
            Console.Write(drawer.Draw(x, y));
        }
    }
}