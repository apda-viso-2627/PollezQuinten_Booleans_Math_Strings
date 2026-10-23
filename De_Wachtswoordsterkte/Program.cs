Console.WriteLine("Geef een wachtwoord in: ");
string wachtwoord = Console.ReadLine();
int score = 0;
int lengte = wachtwoord.Length;


if (wachtwoord.Length > 8)
{
    score += 1;
    Console.WriteLine("Uw wachtwoord is langer dan 8 tekens");
}
else
    Console.WriteLine("Uw wachtwoord is korter dan 8 tekens");

if (wachtwoord.Any(char.IsUpper))
{
    score += 1;
    Console.WriteLine("Uw wachtwoord bevat een hoofdletter");
}
else
    Console.WriteLine("Uw wachtwoord heeft geen hoofdletter");

if (wachtwoord.Any(char.IsLower))
{
    score += 1;
    Console.WriteLine("Uw wachtwoord heeft een kleine letter");
}
else
    Console.WriteLine("Uw wachtwooord heeft geen kleine letter");

if (wachtwoord.Any(char.IsDigit))
{
    score += 1;
    Console.WriteLine("Uw wachtwoord heeft een getal");
}
else
    Console.WriteLine("Uw wachtwoord heeft geen getal");

if (wachtwoord.Any(char.IsSymbol))
{
    score += 1;
    Console.WriteLine("Uw wachtwoord heeft een leesteken");
}
else
    Console.WriteLine("Uw wachtwoord heeft geen leesteken");

Console.WriteLine("Press enter ...");

string x = Console.ReadLine();

Console.WriteLine($"Wachtwoord: {wachtwoord}");
Console.WriteLine($"Score: {score} van 5");