/*
Bin 1 = 200 items (Running total: 200)
Bin 2 = 450 items (Running total: 650)
Bin 3 = 700 items (Running total: 1350)
Bin 4 = 175 items (Running total: 1525)
Bin 5 = 250 items (Running total: 1775)
We have 1775 items in inventory.
*/

int binChiling = 0;
int[] items = { 200, 450, 700, 175, 250 };
int totalSum = 0;
foreach (int item in items)
{
    totalSum += item;
    binChiling++;
    Console.WriteLine($"Bin {binChiling} = {item} items (Running total: {totalSum})");
}
Console.WriteLine($"We have {totalSum} items in inventory.");