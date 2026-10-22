Console.WriteLine("Geef een wachtwoord in: ");
string wachtwoord = Console.ReadLine();
int score = 0;
int lengte = wachtwoord.Length;
bool heeftHoofdletter = false;
bool heeftKleineLetter = false;
bool heeftCijfer = true;



for (int i = 0; i < lengte; i++)
{
    if (wachtwoord[i] == ' ')
    {
        score -= 1;
    }
}

if (wachtwoord.Length > 8)
{
    score += 1;
}

if (wachtwoord.Any(char.IsUpper))
{
    score += 1;
}

if (wachtwoord.Any(char.IsLower))
{
    score += 1;
}
if (wachtwoord.Any(char.IsDigit))
{
    score += 1;
}


Task.Delay(500).Wait();
Console.Clear();
Console.WriteLine($"Wachtwoord: {wachtwoord}");
Console.WriteLine($"Score: {score} van 5");
Console.WriteLine("Ontbreekt nog: ");
