/*
Monster was damaged and lost 1 health and now has 9 health.
Hero was damaged and lost 1 health and now has 9 health.
Monster was damaged and lost 7 health and now has 2 health.
Hero was damaged and lost 6 health and now has 3 health.
Monster was damaged and lost 9 health and now has -7 health.
Hero wins!
*/

int monsterHP = 10;
int heroHP = 10;
bool heroTurn = true;
Random randGen = new Random();
do
{
    int attack = randGen.Next(1, 10);
    if (heroTurn)
    {
        Console.WriteLine("The hero is getting ready to attack..");
        monsterHP -= attack;
        heroTurn = false;
        Console.WriteLine($"Monster was damaged and lost {attack} health!");
        Console.WriteLine("MONSTER ["+monsterHP+"HP]\n");
    }
    else
    {
        Console.WriteLine("The monster is getting ready to attack..");
        heroHP -= attack;
        heroTurn = true;
        Console.WriteLine($"Hero was damaged and lost {attack} health!\n[{heroHP}HP Remaining]");
        Console.WriteLine("HERO ["+heroHP+"HP]\n");
    }
}
while (heroHP > 0 && monsterHP > 0);

Console.WriteLine(heroHP > monsterHP ? "Hero wins!" : "GAME OVER.");