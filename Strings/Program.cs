Console.WriteLine("Wat is uw voornaam?");
string voornaam = Console.ReadLine();

Console.WriteLine("Wat is uw achternaam?");
string achternaam = Console.ReadLine();
voornaam = voornaam.ToLower();
achternaam = achternaam.ToLower();

Console.WriteLine($"Je naam is {voornaam} {achternaam}");
