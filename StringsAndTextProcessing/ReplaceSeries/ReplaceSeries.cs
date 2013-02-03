using System;
using System.Linq;
using System.Text;

class ReplaceSeries
{
    static void Main()
    {
        string input = "aaaaabbbbbcdddeeeedssaadddddddddddaaaaaaaaaaooooooooooqqqqqqqq";
        char currentChar = input[0];
        StringBuilder output = new StringBuilder();
        output.Append(currentChar);

        for (int index = 0; index < input.Length; index++)
        {
            if (input[index] != currentChar)
            {
                currentChar = input[index];
                output.Append(currentChar);
            }
        }

        Console.WriteLine(output);
    }
}
