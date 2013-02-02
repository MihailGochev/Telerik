using System;
using System.Linq;

class ReverseString
{
    static void Main()
    {
        Console.WriteLine("Please enter the string:");
        string input = Console.ReadLine();

        char[] output = input.ToArray();
        Array.Reverse(output);
        Console.WriteLine("Reversed string:");
        Console.WriteLine(output);
    }
}

