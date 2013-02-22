using System;
using System.Linq;

class AlphabeticalOrder
{
    static void Main()
    {
        string input = "these are some random words i came up to while drinking beer quite a lot after midnight";
        string[] splitInput = input.Split();

        Array.Sort(splitInput);
        foreach (var word in splitInput)
        {
            Console.WriteLine(word);    
        }
    }
}

