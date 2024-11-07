using System.Reflection.Metadata;

// if (6 >= 3)
// {
//     System.Console.WriteLine("Hello World");
// }

System.Console.WriteLine("Enter Username and password");
string User = Console.ReadLine();
string Pass = Console.ReadLine();

if (User == "noname" && Pass == "nopass")
{
    System.Console.WriteLine("Welcome");
}
else 
{
    System.Console.WriteLine("Wrong username or password");
}


Console.ReadLine();