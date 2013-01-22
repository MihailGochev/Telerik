using System;
using System.IO;
using System.Linq;

class PrintOddLines
{
    static void Main()
    {
        StreamReader inputFile = new StreamReader(@"..\..\input.txt");
        string input;

        using (inputFile)
        {
            input = inputFile.ReadToEnd();
        }

        string[] lines = input.Split('\n');

        for (int line = 0; line < lines.Length; line++)
        {
            if (line % 2 == 1)
            {
                Console.Write(lines[line]);
                Console.WriteLine();
            }
        }

    }
}
