/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/

Random rand = new Random();
string[] orderIDs = new string[5];
string threeDigitRandom;
char[] letterRandom = { 'A', 'B', 'C', 'D', 'E' };
for (int i = 0; i < 5; i++)
{
    threeDigitRandom = rand.Next(1, 10).ToString("000");
    orderIDs[i] = letterRandom[rand.Next(0, 4)].ToString() + threeDigitRandom.ToString();
}

foreach (string order in orderIDs)
{
    Console.WriteLine(order);
}

MyNewTestSubject.Run();