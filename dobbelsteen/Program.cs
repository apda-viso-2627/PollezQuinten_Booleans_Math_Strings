Random rnd = new Random(); // EEN keer, boven je lus
int max = int.MinValue;
int min = int.MaxValue;
int totaal = 0;
for (int i = 0; i <= 5; i++)
{
    int worp = rnd.Next(1, 7); // 1 t.e.m. 6 (de 7 komt er nooit uit)

    Console.WriteLine($"Worp {i + 1}: {worp}");
    totaal += worp;
    if (worp > max) max = worp;
    if (worp < min) min = worp;
}

Console.WriteLine($"Hoogste worp: {max}");
Console.WriteLine($"Laagste worp: {min}");
Console.WriteLine($"Totaal: {totaal}");

