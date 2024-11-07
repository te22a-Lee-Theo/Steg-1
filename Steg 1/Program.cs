using System.Reflection.Metadata;

// if (6 >= 3)
// {
//     System.Console.WriteLine("Hello World");
// }

// System.Console.WriteLine("Enter Username and password");
// string User = Console.ReadLine();
// string Pass = Console.ReadLine();

// if (User == "noname" && Pass == "nopass")
// {
//     System.Console.WriteLine("Welcome");
// }
// else 
// {
//     System.Console.WriteLine("Wrong username or password");
// }

// for (int i = 0; i < 32; i++)
// {
//     System.Console.WriteLine("Hello world");
// }


System.Console.WriteLine("Enter your password");
string Pass;

while (true)
{
    Pass = Console.ReadLine();
    if (Pass == "nopass")
    {
        System.Console.WriteLine("Welcome");
        break;
    }
    else 
    {
        System.Console.WriteLine("Wrong password");
    }
}


Console.ReadLine();