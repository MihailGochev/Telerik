using System;
using System.IO;
using System.Linq;

class InsertLineNumbers
{
    static void Main()
    {
        StreamReader inputFile = new StreamReader(@"..\..\input.txt");
        StreamWriter outputFile = new StreamWriter(@"..\..\output.txt");
        string input;

        using (inputFile)
        {
            input = inputFile.ReadToEnd();
        }

        string[] lines = input.Split('\n');

        using (outputFile)
        {
            for (int line = 0; line < lines.Length; line++)
            {
                outputFile.Write("{0}: {1}", line + 1, lines[line]);
            }
        }
    }
}
