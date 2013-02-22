using System;
using System.Linq;

class ForbiddenWords
{
    static void Main()
    {
        string input = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string words = "PHP,CLR,Microsoft,next,.NET";
        string[] forbiddenWords = words.Split(',');

        foreach (var word in forbiddenWords)
        {
            input = input.Replace(word, new string('*', word.Length));
        }

        Console.WriteLine(input);
    }
}
