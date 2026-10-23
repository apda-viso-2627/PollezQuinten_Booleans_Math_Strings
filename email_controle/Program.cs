Console.WriteLine("Voer een e-mailadres in: ");
string mail = Console.ReadLine();

if (mail.Contains("@") && mail.Contains("."))
{
    Console.WriteLine("Geldig adres");
}
else
{
    Console.WriteLine("Ongeldig adres");
}

