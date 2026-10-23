Console.WriteLine("Voer een zin in: ");
string zin = Console.ReadLine();

Console.WriteLine("Voer een letter in: ");
string letter = Console.ReadLine();

for (int i = 0; i < zin.Length; i++)
{
    if (zin[i].ToString().ToLower() == letter.ToLower())
    {
        Console.WriteLine($"De letter {letter} komt voor op positie {i + 1}");
    }
}