using SquareAndCross;

var size = 11;


var drawer = new SquareDrawer(size);
for(var y = 0; y < size; y++)
{
    for (var x = 0; x < size; x++)
    {
        Console.Write(drawer.Draw(x, y));
    }
}