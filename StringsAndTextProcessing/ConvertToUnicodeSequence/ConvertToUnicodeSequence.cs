using System;
using System.Linq;

class ConvertToUnicodeSequence
{
    static void Main()
    {
        string input = "The quick brown fox jumps over the lazy dog!";

        for (int index = 0; index < input.Length; index++)
        {

            Console.Write("\\u{0}", Convert.ToString(input[index], 16).PadLeft(4,'0'));
        }
        Console.WriteLine();
    }
}
