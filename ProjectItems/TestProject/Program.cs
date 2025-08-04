void DiceRolling()
{
    Random roll = new Random();
    List<int> rolled = new List<int>();
    int total = 0;
    for (int i = 0; i < 3; i++)
    {
        int randomRoll = roll.Next(1, 6);
        rolled.Add(randomRoll);
        total += randomRoll;
    }

    Console.WriteLine($"Dice roll: {rolled[0]} + {rolled[1]} + {rolled[2]} = {total}");
    if (rolled[0] == rolled[1] || rolled[0] == rolled[2] || rolled[1] == rolled[2])
    {
        if (rolled[0] == rolled[1] && rolled[1] == rolled[2])
        {
            total += 6;
            Console.WriteLine($"You rolled triples! +6 bonus to total!");
        }
        else
        {
            total += 2;
            Console.WriteLine($"You rolled doubles! +2 bonus to total!");
        }
    }

    if (total >= 15)
    {
        Console.WriteLine($"YOU WIN! \t Total: {total}");
    }
    else
    {
        Console.WriteLine($"Sorry, you lost.. \t Total: {total}");
    }
    Console.WriteLine("------------------");
}

for (int i = 0; i < 5; i++)
{
    DiceRolling();
}