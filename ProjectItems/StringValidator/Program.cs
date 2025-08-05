/*
Enter your role name (Administrator, Manager, or User)
Admin
The role name that you entered, "Admin" is not valid. Enter your role name (Administrator, Manager, or User)
   Administrator
Your input value (Administrator) has been accepted.
*/

string? rolename;
bool found = false;
Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
do
{
    Console.Write("Role: ");
    rolename = Console.ReadLine();
    switch (rolename.ToLower().Trim())
    {
        case "administrator":
        case "manager":
        case "user":
            Console.WriteLine($"Your input value ({rolename}) has been accepted.");
            found = true;
            break;
        default:
            Console.WriteLine($"The role name that you entered, \"{rolename}\" is not valid.");
            Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
            break;
    }
}
while (found == false);