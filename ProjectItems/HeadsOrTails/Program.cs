Random rand = new Random();
string coinflip = rand.Next(0, 2) == 0 ? "Heads" : "Tails";
Console.WriteLine(coinflip);