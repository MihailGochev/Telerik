using System;
using System.Linq;
using System.Text;

class ConvertNumeralSystem
{
    static void Main()
    {
        int inputBase = 10;
        int outputBase = 8;
        string number = "200";

        Console.WriteLine(ConvertNumber(inputBase, outputBase, number));
    }

    static string ConvertNumber(int baseInput, int baseOutput, string number)
    {
        number = number.ToUpper();
        long decimalRepresentation = 0;

        if (baseInput != 10)    
        {

            for (int index = 0, power = number.Length - 1; index < number.Length; index++, power--)
            {
                if (Char.IsDigit(number[index]))
                {
                    decimalRepresentation += (number[index] - 48) * (long)Math.Pow(baseInput, power);
                }
                else
                {
                    decimalRepresentation += (number[index] - 55) * (long)Math.Pow(baseInput, power);
                }
            }
        }
        else
        {
            decimalRepresentation = int.Parse(number);
        }

        StringBuilder outputNumber = new StringBuilder();

        while (decimalRepresentation > 0)
        {
            long reminder = decimalRepresentation % baseOutput;
            if (reminder <= 9)
            {
                outputNumber.Insert(0, reminder);
            }
            else
            {
                outputNumber.Insert(0, ((char)(reminder + 55)));
            }

            decimalRepresentation /= baseOutput;
        }

        return outputNumber.ToString();
    }
}

