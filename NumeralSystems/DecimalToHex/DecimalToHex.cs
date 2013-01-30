using System;
using System.Linq;
using System.Text;

class DecimalToHex
{
    static void Main()
    {
        int number = 240;
        Console.WriteLine("{0} in hexadecimal is: {1}", number, ConvertDecToHex(number));
    }

    static string ConvertDecToHex(int number)
    {
        int baseOutput = 16;
        StringBuilder outputNumber = new StringBuilder();

        while (number > 0)
        {
            long reminder = number % baseOutput;
            if (reminder <= 9)
            {
                outputNumber.Insert(0, reminder);
            }
            else
            {
                outputNumber.Insert(0, ((char)(reminder + 55)));
            }

            number /= baseOutput;
        }

        return outputNumber.ToString();
    }
}