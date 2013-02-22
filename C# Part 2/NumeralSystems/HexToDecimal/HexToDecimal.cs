using System;
using System.Linq;

class BinaryToDecimal
{
    static void Main()
    {
        string number = "F0";
        Console.WriteLine("{0} in decimal is: {1}", number, ConvertHexToDec(number));
    }

    static long ConvertHexToDec(string number)
    {
        int baseInput = 16;
        number = number.ToUpper();
        long decimalRepresentation = 0;

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
        return decimalRepresentation;
    }
}

