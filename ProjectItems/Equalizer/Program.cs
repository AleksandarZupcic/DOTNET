string valueOne = readjustTexter("alex");
string valueTwo = readjustTexter(" ALex ");
if (valueOne == valueTwo)
{
    Console.WriteLine($"Hello, Alex!");
}
else
{
    Console.WriteLine("no");
}

string chatGPTText = "Let me know if you want to flip to a full Main() style project next or keep flying top-lvel."; 
Console.WriteLine(chatGPTText.Contains(readjustTexter("STYLE")));




string readjustTexter(string text)
{
    return text.Trim().ToLower();
}