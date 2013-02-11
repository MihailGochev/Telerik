using System;
using System.Text;
using System.Numerics;

class ProvadiaNumbers
{

    static void Main()
    {
        //Reading the input
        BigInteger input = BigInteger.Parse(Console.ReadLine());

        //Converting
        StringBuilder output = ConvertNumber(input);

        //Printing
        Console.WriteLine(output);
    }

    static StringBuilder ConvertNumber(BigInteger number)
    {
        StringBuilder output = new StringBuilder();
        int baseOutput = 256;

        if (number == 0)
        {
            output.Insert(0, ConvertDecimalToProvadia(number));
        }

        //Converting the number
        while (number > 0)
        {
            BigInteger reminder = number % baseOutput;
            //Filling the output from right to left
            output.Insert(0, ConvertDecimalToProvadia(reminder));

            number /= baseOutput;
        }

        return output;
    }

    static string ConvertDecimalToProvadia(BigInteger number)
    {
        //Calculating the right letter.
        char firstLetter = (char)(number % 26 + 'A');
        if (number > 25)
        {
            //Calculating the left letter
            char secondLetter = (char)(number / 26 + 'a' - 1);
            return String.Format("{0}{1}", secondLetter, firstLetter);
        }

        return String.Format("{0}", firstLetter);
    }

}