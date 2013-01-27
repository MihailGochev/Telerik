using System;
using System.Linq;
using System.Text;

class DecimalToBinary
{
    static void Main()
    {
        short number = short.MaxValue;

        Console.WriteLine("{0} in binary is: {1}", number, ConvertDecToBin(number).PadLeft(16, '0'));

        number = short.MinValue;

        Console.WriteLine("{0} in binary is: {1}", number, ConvertDecToBin(number).PadLeft(16, '0'));

    }

    static string ConvertDecToBin(int number)
    {
        int baseOutput = 2;

        if (number < 0)
        {
            number *= -1;
        }


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