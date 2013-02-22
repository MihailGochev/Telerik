using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class DeleteWords
{
    static void Main()
    {
        StreamReader inputFile = new StreamReader("../../input.txt");
        StreamWriter outputFile = new StreamWriter("../../output.txt");

        using (inputFile)
        {
            using (outputFile)
            {
                string line = inputFile.ReadLine();
                while (line != null)
                {
                    line = Regex.Replace(line, @"\btest\w*\b", String.Empty);
                    outputFile.WriteLine(line);
                    line = inputFile.ReadLine();
                }
            }
        }
    }
}
