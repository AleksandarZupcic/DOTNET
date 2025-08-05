string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
string stringer = "";
int periodIn = 0;

for (int i = 0; i < myStrings.Length; i++)
{
    stringer = myStrings[i];
    periodIn = stringer.IndexOf(".");
    string? sentence;
    while (periodIn != -1)
    {
        sentence = stringer.Remove(periodIn);
        stringer = stringer.Substring(periodIn + 1).Trim();
        periodIn = stringer.IndexOf(".");
        Console.WriteLine(sentence);
    }
    sentence = stringer.Trim();
    Console.WriteLine(sentence);
}