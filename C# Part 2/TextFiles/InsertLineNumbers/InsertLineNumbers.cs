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
            using (outputFile)
            {
                int line = 1;
                input = inputFile.ReadLine();
                while (input != null)
                {
                    outputFile.WriteLine("{0}: {1}", line, input);
                    line++;
                    input = inputFile.ReadLine();
                }
            }
        }
    }
}
