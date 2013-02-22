using System;
using System.Linq;
using System.Text.RegularExpressions;

class CorrectBrackets
{
    static void Main()
    {
        Console.WriteLine("Please enter the input string:");
        string input = Console.ReadLine();
        Console.WriteLine("Please enter the substring:");
        string inputSubstring = Console.ReadLine();

        int count = Regex.Matches(input, inputSubstring, RegexOptions.IgnoreCase).Count;
        Console.WriteLine("The number of substring appearances: {0}", count);

    }
}

