using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class SortStringsFromFile
{
    static void Main()
    {
        StreamReader inputFile = new StreamReader(@"..\..\input.txt");
        StreamWriter outputFile = new StreamWriter(@"..\..\output.txt");
        List<string> input = new List<string>();

        using (inputFile)
        {
            string line = inputFile.ReadLine();
            while (line != null)
            {
                input.Add(line);
                line = inputFile.ReadLine();
            }

        }
        input.Sort();
        using (outputFile)
        {
            foreach (var line in input)
            {
                outputFile.WriteLine(line);
            }
        }
    }
}
