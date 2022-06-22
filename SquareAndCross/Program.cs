for(var y = 0; y < 11; y++)
{
    for (var x = 0; x < 11; x++)
    {
        if (x == 0 || x == 10 || y == 0 || y == 10 || x==y || 10-x == y)
            Console.Write("#");
        else
            Console.Write(" ");
    }
    Console.Write(Environment.NewLine);
}