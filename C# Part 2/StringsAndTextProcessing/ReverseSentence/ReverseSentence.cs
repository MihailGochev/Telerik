using System;
using System.Linq;

class ReverseSentence
{
    static void Main()
    {
        string input = "C# is not C++, not PHP and not Delphi! Another sentence for testing?";
        string[] words = input.Split(new char[] { '!', ' ', ',', '?' });
        int wordIndex = words.Length - 1;
        for (int index = 0; index < input.Length; index++)
        {
            if (Char.IsPunctuation(input[index]) || Char.IsSeparator(input[index]))
            {
                Console.Write("{0}{1}", words[wordIndex--], input[index] == '#' ? "" : input[index].ToString());
            }
        }
        Console.WriteLine();
    }
}