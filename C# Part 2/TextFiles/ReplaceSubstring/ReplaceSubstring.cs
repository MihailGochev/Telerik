using System;
using System.IO;
using System.Linq;

class ReplaceSubstring
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
                    line=line.Replace("start", "finish");
                    outputFile.WriteLine(line);
                    line = inputFile.ReadLine();
                }
            }
        }
    }
}
