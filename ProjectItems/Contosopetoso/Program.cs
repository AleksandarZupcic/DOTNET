class Program
{
    public static void Main(string[] args)
    {
        string[,] ourAnimals;ourAnimals = new string[10, 6]
        {
            { "001", "Dog", "3", "Golden fur, medium build", "Playful and energetic", "Buddy" },
            { "002", "Cat", "2", "Short-haired gray", "Quiet and affectionate", "Mittens" },
            { "003", "Dog", "5", "Large black lab", "Loyal and protective", "Shadow" },
            { "004", "Cat", "1", "Fluffy white", "Curious and vocal", "Snowball" },
            { "005", "Dog", "4", "Brown with white paws", "Gentle and calm", "Rusty" },
            { "006", "Dog", "3", "Golden fur, medium build", "Gentle and calm", "Max" },
            { "007", "Cat", "2", "Short-haired gray", "Playful and energetic", "Luna" },
            { "008", "Dog", "5", "Large black lab", "Calm and observant", "Bear" },
            { "009", "Cat", "4", "Fluffy white", "Quiet and affectionate", "Whiskers" },
            { "010", "Dog", "1", "Brown with white paws", "Curious and vocal", "Scout" }
        };

        PetCommander pet = new PetCommander();

        string[] mainMenuOptions = new string[]
        {
            "1. List all of our current pet information",
            "2. Add a new animal friend to the ourAnimals array",
            "3. Ensure animal ages and physical descriptions are complete",
            "4. Ensure animal nicknames and personality descriptions are complete",
            "5. Edit an animal’s age",
            "6. Edit an animal’s personality description",
            "7. Display all cats with a specified characteristic",
            "8. Display all dogs with a specified characteristic"
        };

        Console.WriteLine("Welcome to the Contoso PetFriends app!");
        ListMenuOptions(mainMenuOptions);
        string command = EnterSelectionNumber();

        do
        {
            switch (command)
            {
                case "1":
                    // "1. List all of our current pet information",
                    Console.WriteLine($"You chose.. Option {mainMenuOptions[int.Parse(command) - 1]}");
                    pet.ListAllPetInfo(ourAnimals);
                    command = StartMenuOver(mainMenuOptions);
                    break;
                case "2":
                    // "2. Add a new animal friend to the ourAnimals array",
                    Console.WriteLine($"You chose.. Option {mainMenuOptions[int.Parse(command) - 1]}");
                    pet.AddNewAnimal(ourAnimals);
                    command = StartMenuOver(mainMenuOptions);
                    break;
                case "3":
                    // "3. Ensure animal ages and physical descriptions are complete",
                    Console.WriteLine($"You chose.. Option {mainMenuOptions[int.Parse(command) - 1]}");
                    command = StartMenuOver(mainMenuOptions);
                    break;
                case "4":
                    // "4. Ensure animal nicknames and personality descriptions are complete",
                    Console.WriteLine($"You chose.. Option {mainMenuOptions[int.Parse(command) - 1]}");
                    command = StartMenuOver(mainMenuOptions);
                    break;
                case "5":
                    // "5. Edit an animal’s age",
                    Console.WriteLine($"You chose.. Option {mainMenuOptions[int.Parse(command) - 1]}");
                    command = StartMenuOver(mainMenuOptions);
                    break;
                case "6":
                    // "6. Edit an animal’s personality description",
                    Console.WriteLine($"You chose.. Option {mainMenuOptions[int.Parse(command) - 1]}");
                    command = StartMenuOver(mainMenuOptions);
                    break;
                case "7":
                    // "7. Display all cats with a specified characteristic",
                    Console.WriteLine($"You chose.. Option {mainMenuOptions[int.Parse(command) - 1]}");
                    command = StartMenuOver(mainMenuOptions);
                    break;
                case "8":
                    // "8. Display all dogs with a specified characteristic"
                    Console.WriteLine($"You chose.. Option {mainMenuOptions[int.Parse(command) - 1]}");
                    command = StartMenuOver(mainMenuOptions);
                    break;
                default:
                    Console.WriteLine("Wrong command.. Try again.");
                    command = StartMenuOver(mainMenuOptions);
                    break;
            }
        }
        while (command != "exit");
    }

    public static void ListMenuOptions(string[] mainMenuOptions)
    {
        Console.WriteLine("Your main menu options are..");
        foreach (string menuOption in mainMenuOptions)
        {
            Console.WriteLine(menuOption);
            Thread.Sleep(500);
        }
        Console.WriteLine();
    }

    public static string ReadMeHard(string item)
    {
        Console.WriteLine($"{item}: ");
        string? readHard = Console.ReadLine();
        while (readHard == null)
        {
            Console.WriteLine("Item cannot be empty.");
            Console.WriteLine($"{item}: ");
            readHard = Console.ReadLine();
        }
        return readHard;
    }

    public static string EnterSelectionNumber()
    {
        Console.Write("Enter your selection number (or type Exit to exit the program): ");
        string? command = Console.ReadLine();
        while (command == null)
        {
            Console.WriteLine("No command found..");
            Console.Write("Enter your selection number (or type Exit to exit the program): ");
            command = Console.ReadLine();
        }
        return command;
    }

    public static string StartMenuOver(string[] mainMenuOptions)
    {
        ListMenuOptions(mainMenuOptions);
        return EnterSelectionNumber();
    }
    
    public static void TypeWriteMe(string output)
    {
        foreach (char c in output)
        {
            Console.Write(c);
            Thread.Sleep(2);
        }
    }
}





// "1. List all of our current pet information"
/*
string[,] ourAnimals = new string[10, 6]
{
    { "001", "Dog", "3", "Golden fur, medium build", "Playful and energetic", "Buddy" },
*/

/*
void ListAllPetInfo(string[,] ourAnimals)
{
    Thread.Sleep(1000);
    Console.Write("Fetching all the pet info");
    for (int i = 0; i < 3; i++)
    {
        Console.Write(".");
        Thread.Sleep(1000);
    }
    Thread.Sleep(2000);
    for (int i = 0; i < ourAnimals.GetLength(0); i++)
    {
        string output = $@"
            ID: {ourAnimals[i, 0]}
            Type: {ourAnimals[i, 1]}
            Age: {ourAnimals[i, 2]}
            Description: {ourAnimals[i, 3]}
            Personality: {ourAnimals[i, 4]}
            Nickname: {ourAnimals[i, 5]}
            --------------------------------
        ".Replace("            ", "");
        TypeWriteMe(output);
    }
}
*/
