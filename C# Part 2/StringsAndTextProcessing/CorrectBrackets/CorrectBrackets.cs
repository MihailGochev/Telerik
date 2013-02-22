using System;
using System.Linq;

class CorrectBrackets
{
    static void Main()
    {
        Console.WriteLine("Please enter the string:");
        string input = Console.ReadLine();

        Console.WriteLine("The brackets are put correctly: {0}", CheckBrackets(input));
    }

    static bool CheckBrackets(string input)
    {
        int index = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                index++;
            }
            else if (input[i] == ')')
            {
                index--;
                if (index < 0)
                {
                    return false;
                }
            }
        }

        if (index == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

