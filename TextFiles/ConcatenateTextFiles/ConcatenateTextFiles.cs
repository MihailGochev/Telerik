using System;
using System.IO;
using System.Linq;

class ConcatenateTextFiles
{
    static void Main()
    {
        StreamReader inputFile = new StreamReader(@"..\..\input.txt");
        StreamReader inputFile2 = new StreamReader(@"..\..\input2.txt");
        StreamWriter outputFile = new StreamWriter(@"..\..\output.txt");
        string input;

        using (inputFile)
        {
            using (inputFile2)
            {

                using (outputFile)
                {
                    input = inputFile.ReadLine();
                    while (input != null)
                    {
                        outputFile.WriteLine(input);
                        input = inputFile.ReadLine();
                    }
                    input = inputFile2.ReadLine();
                    while (input != null)
                    {
                        outputFile.WriteLine(input);
                        input = inputFile2.ReadLine();
                    }
                }
            }
        }
    }
}
