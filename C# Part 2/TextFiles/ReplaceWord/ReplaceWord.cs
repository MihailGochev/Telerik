using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;


class ReplaceWord
{
    static void Main()
    {
        StreamReader inputFile = new StreamReader(@"..\..\input.txt");
        StreamWriter outputFile = new StreamWriter(@"..\..\output.txt");

        using (inputFile)
        {
            using (outputFile)
            {
                string line = inputFile.ReadLine();
                while (line != null)
                {
                    outputFile.WriteLine(Regex.Replace(line, "\\bstart\\b", "finish"));
                    line = inputFile.ReadLine();
                }
            }
        }
    }
}
