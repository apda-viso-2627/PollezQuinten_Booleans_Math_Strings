Random rnd = new Random();

int max = int.MinValue;
int min = int.MaxValue;
int totaal = 0;
for (int x = 0; x < 5; x += 3)
{
    int worp = rnd.Next(1, 7);
    if (x < 3)
    {
        for (int i = 0; i <= 2; i++)
        {
            worp = rnd.Next(1, 7);
            Console.Write($"Roll {i + 1}: {worp}");
            Console.Write("          ");
        }
    }
    else if (x >= 3)
    {
        Console.WriteLine();
        for (int i = 3; i <= 5; i++)
        {
            worp = rnd.Next(1, 7);
            Console.Write($"Roll {i + 1}: {worp}");
            Console.Write("          ");
        }



        totaal += worp;
        if (worp > max) max = worp;
        if (worp < min) min = worp;
    }
}
Console.WriteLine();
Console.Write($"Highest roll: {max}            ");
Console.Write($"Lowest roll: {min}            ");
Console.Write("Total of points: " + totaal);