using System;
using System.Linq;

class ReverseSentence
{
    static void Main()
    {
        string input = "C# is not C++, not PHP and not Delphi!";
        string[] words = input.Split(new char[] { '!', ' ', ',', '#' });
        words.Reverse();
        int wordIndex = 0;
        for (int index = 0; index < input.Length; index++)
        {
            if (Char.IsPunctuation(input[index]) || Char.IsSeparator(input[index]))
            {
                Console.Write("{0}{1}", words[wordIndex++], input[index]);
            }
        }
        Console.WriteLine();
    }
}