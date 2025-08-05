/*
Enter an integer value between 5 and 10
two
Sorry, you entered an invalid number, please try again
2
You entered 2. Please enter a number between 5 and 10.
7
Your input value (7) has been accepted.
*/


Console.WriteLine("Enter an integer value between 5 and 10");
string? numberGuesser;
int guessedNumber = 0;
bool validNumber = false;

do
{
    numberGuesser = Console.ReadLine();
    validNumber = int.TryParse(numberGuesser, out guessedNumber);
    if (!validNumber)
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again..");
    }
    else if (guessedNumber > 5 && guessedNumber < 10)
    {
        Console.WriteLine("Your input value (" + guessedNumber + ") has been accepted.");
        break;
    }
    else
    {
        Console.WriteLine($"You entered {guessedNumber}. Please enter a number between 5 and 10.");
    }
} while (true);
