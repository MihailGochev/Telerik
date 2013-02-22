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
            int line = 1;           
            input = inputFile.ReadLine();
            while (input != null)
            {
                if (line % 2 == 1)
                {
                    Console.WriteLine(input);
                }
                line++;
                input = inputFile.ReadLine();
            }
        }
    }
}
