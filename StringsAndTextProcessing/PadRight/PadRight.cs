using System;
using System.Linq;

class PadRight
{
    static void Main()
    {
        Console.WriteLine("Please enter the string:");
        string input = Console.ReadLine();

        Console.WriteLine(input.PadRight(20, '*'));
    }
}

