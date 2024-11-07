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

// System.Console.WriteLine("Enter your password");
// string Pass;

// while (true)
// {
//     Pass = Console.ReadLine();
//     if (Pass == "nopass")
//     {
//         System.Console.WriteLine("Welcome");
//         break;
//     }
//     else 
//     {
//         System.Console.WriteLine("Wrong password");
//     }
// }

// for (int i = 0; i <= 4; i++)
// {
//     System.Console.WriteLine("Enter a number");
//     string Usernum = Console.ReadLine();
//     int Num = int.Parse(Usernum);
//     if (Num > 5)
//     {
//         System.Console.WriteLine("Höger än 5!");
//     }
//     else if (Num < 5)
//     {
//         System.Console.WriteLine("Lägre än 5");
//     }
//     else
//     {
//         System.Console.WriteLine(Num);
//     }
// }

// bool TrueorFalse = false;

// while (TrueorFalse == false)
// {
//     string Input = Console.ReadLine();
//     int Num;
//     TrueorFalse = int.TryParse(Input, out Num);
// }


System.Console.WriteLine("Time for a game of guess the number");
System.Console.WriteLine("Just enter a number between 1 and 10 and I'll tell you wether your wrong or right");

int Ans = Random.Shared.Next(1, 10);

while (true)
{
    System.Console.WriteLine("Enter your guess");
    string Input = Console.ReadLine();
    int Num;
    bool Convert = int.TryParse(Input, out Num);

    if (Num == Ans)
    {
        System.Console.WriteLine("Correct, you win");
        break;
    }
    else if (Num < Ans)
    {
        System.Console.WriteLine("Incorrect, try guessing higher");
    }
    else if (Num > Ans)
    {
        System.Console.WriteLine("Incorrect, try guessing lower");
    }
    else
    {
        System.Console.WriteLine("That's wrong \nTry again");
    }
}



Console.ReadLine();