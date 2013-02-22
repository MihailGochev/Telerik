using System;
using System.IO;
using System.Linq;

class CompareTextFiles
{
    static void Main()
    {
        StreamReader inputFile = new StreamReader(@"..\..\input.txt");
        StreamReader inputFile2 = new StreamReader(@"..\..\input2.txt");
        string input, input2;
        int numberOfEqualLines = 0;
        int numberOfDifferentLines = 0;

        using (inputFile)
        {
            using (inputFile2)
            {
                input = inputFile.ReadLine();
                input2 = inputFile2.ReadLine();

                while (input != null && input2 != null)
                {

                    if (input == input2)
                    {
                        numberOfEqualLines++;
                        Console.WriteLine("{0} = {1}", input, input2);
                    }
                    else
                    {
                        if (string.Compare(input, input2) > 0)
                        {
                            Console.WriteLine("{0} > {1}", input, input2);
                        }
                        else
                        {
                            Console.WriteLine("{0} < {1}", input, input2);
                        }

                        numberOfDifferentLines++;

                    }
                    input = inputFile.ReadLine();
                    input2 = inputFile2.ReadLine();
                }
            }
        }

        Console.WriteLine("The two files have {0} equal lines and {0} different lines.", numberOfEqualLines, numberOfDifferentLines);
    }
}