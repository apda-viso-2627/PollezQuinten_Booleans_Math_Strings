Console.WriteLine("Enter your age:");
int age = int.Parse(Console.ReadLine());

Console.WriteLine("Do you have a ticket? (true/false)");
bool ticket = bool.Parse(Console.ReadLine());

Console.WriteLine("Are you on the blacklist? (true/false)");
bool blacklist = bool.Parse(Console.ReadLine());

if (age >= 16 && ticket == true && blacklist == false)
{
    Console.WriteLine("You are allowed to enter the festival.");
}
else if (age < 16)
{
    Console.WriteLine("You are not allowed to enter the festival because you are under 16.");
}
else if (ticket == false)
{
    Console.WriteLine("You are not allowed to enter the festival because you do not have a ticket.");
}
else if (blacklist == true)
{
    Console.WriteLine("You are not allowed to enter the festival because you are on the blacklist.");
}
else
{
    Console.WriteLine("You are not allowed to enter the festival.");
}