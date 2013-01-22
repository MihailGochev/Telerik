using System;
using System.Linq;

class CompareArrayLexicographically
{
    static void Main()
    {
        Console.WriteLine("First word:");
        string firstWord = Console.ReadLine();
        Console.WriteLine("Second word:");
        string secondWord = Console.ReadLine();
        bool areEqual = true;
        int lowerLength;

        char[] firstArray = (firstWord.ToLower()).ToCharArray();
        char[] secondArray = (secondWord.ToLower()).ToCharArray();

        if (firstArray.Length >= secondArray.Length)
        {
            lowerLength = secondArray.Length;
        }
        else
        {
            lowerLength = firstArray.Length;
        }

        for (int element = 0; element < lowerLength; element++)
        {
            if (firstArray[element] > secondArray[element])
            {
                Console.WriteLine("Letter N{0}: {1} > {2}", element + 1, firstArray[element], secondArray[element]);
                Console.WriteLine("{0} > {1}", firstWord, secondWord);
                areEqual = false;
                break;
            }
            if (firstArray[element] < secondArray[element])
            {
                Console.WriteLine("Letter N{0}: {1} < {2}", element + 1, firstArray[element], secondArray[element]);
                Console.WriteLine("{0} < {1}", firstWord, secondWord);
                areEqual = false;
                break;
            }
        }

        if (areEqual)
        {
            Console.WriteLine("{0} = {1}", firstWord, secondWord);
        }

    }
}