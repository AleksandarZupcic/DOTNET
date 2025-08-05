public class PetCommander
{
    public void ListAllPetInfo(string[,] ourAnimals)
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
            Program.TypeWriteMe(output);
        }
    }

    public void AddNewAnimal(string[,] ourAnimals)
    {
        string petID, petType, petAge, petDescription, petPersonality, petNickname;
        petID = Program.ReadMeHard("ID");
        petType = Program.ReadMeHard("Type");
        petAge = Program.ReadMeHard("Age");
        petDescription = Program.ReadMeHard("Description");
        petPersonality = Program.ReadMeHard("Personality");
        petNickname = Program.ReadMeHard("Nickname");

        int lastRow = ourAnimals.GetLength(0);
        ourAnimals[lastRow, 0] = petID;
        ourAnimals[lastRow, 1] = petType;
        ourAnimals[lastRow, 2] = petAge;
        ourAnimals[lastRow, 3] = petDescription;
        ourAnimals[lastRow, 4] = petPersonality;
        ourAnimals[lastRow, 5] = petNickname;
    }
}