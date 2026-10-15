Console.WriteLine("Wat is de straal van de cirkel?");
double straal = double.Parse(Console.ReadLine());

double oppervlakte = Math.PI * Math.Pow(straal, 2);
double omtrek = 2 * Math.PI * straal;

Console.WriteLine("=====================================");
Console.WriteLine("Straal: " + straal);
Console.WriteLine("");
Console.WriteLine("Oppervlakte: " + oppervlakte);
Console.WriteLine("Omtrek: " + omtrek);
Console.WriteLine("=====================================");