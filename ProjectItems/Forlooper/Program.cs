// Fizz Buzz

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.Write($"{i.ToString("D2")} - FizzBuzz \t");
        Console.WriteLine("");
    }
    else if (i % 3 == 0)
    {
        Console.Write($"{(i < 10 ? "0" : "")}{i} - Fizz \t");
    }
    else if (i % 5 == 0)
    {
        Console.Write($"{i.ToString("D2")} - Buzz \t");
        Console.WriteLine("");
    }
    else
    {
        Console.Write($"{i.ToString("D2")} \t");
    }
}