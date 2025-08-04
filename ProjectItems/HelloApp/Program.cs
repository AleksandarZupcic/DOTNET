Console.WriteLine("Hey there! What's your name?");
Console.Write("Name: ");
string name = Console.ReadLine()!;
while (name == "")
{
    Console.WriteLine("Name cannot be empty!");
    Console.Write("Name:");
    name = Console.ReadLine()!;
}
Console.WriteLine($"Hi {name}!");


Console.WriteLine(5 / 2);