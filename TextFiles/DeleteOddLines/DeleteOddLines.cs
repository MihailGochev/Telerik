using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class PrintOddLines
{
    static void Main()
    {
        StreamReader inputFile = new StreamReader(@"..\..\input.txt");
        List<string> output = new List<string>();

        using (inputFile)
        {
            int line = 1;
            string input = inputFile.ReadLine();
            while (input != null)
            {
                if (line % 2 == 0)
                {
                    output.Add(input);
                }
                line++;
                input = inputFile.ReadLine();
            }
        }

        StreamWriter outputFile = new StreamWriter(@"..\..\input.txt");

        using (outputFile)
        {
            foreach (var line in output)
            {
                outputFile.WriteLine(line);
            }       
        }
    }
}
