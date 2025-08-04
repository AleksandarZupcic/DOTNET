// See https://aka.ms/new-console-template for more information

string name = "";
int age = 0;
string currentlyWorking = "";
bool isWorking = false;

while (name == "")
{
    Console.WriteLine("What is your name?");
    name = Console.ReadLine()!;
    if (name == "") Console.WriteLine("Wrong, try again..");
}

while (age <= 0)
{
    Console.WriteLine("How old are you?");
    age = int.Parse(Console.ReadLine()!);
    if (age <= 0) Console.WriteLine("Wrong, try again..");
}

while (currentlyWorking != "yes" && currentlyWorking != "no")
{
    Console.WriteLine("Are you currently working? (yes/no)");
    currentlyWorking = Console.ReadLine()!.ToLower();
    if (currentlyWorking == "yes")
    {
        isWorking = true;
    }
    else if (currentlyWorking == "no")
    {
        isWorking = false;
    } else {
        Console.WriteLine("Wrong, try again..");
    }
}

Console.WriteLine($"Hi {name}! You are {age} years old and currently working: {isWorking};");