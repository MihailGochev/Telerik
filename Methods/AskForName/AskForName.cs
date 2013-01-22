using System;

class AskForName
{
    static void Main()
    {
        GetNameInfo();
    }

    static void GetNameInfo()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, " + name);
    }
}
