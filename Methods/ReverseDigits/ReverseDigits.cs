using System;

class ReverseDigits
{
    static void Main()
    {
        decimal number = 1545.562122M;
        Console.WriteLine("{0} reversed is {1}", number, ReverseDecimal(number));
    }

    static decimal ReverseDecimal(decimal number)
    {
        char[] digits = number.ToString().ToCharArray();
        Array.Reverse(digits);
        number = decimal.Parse(new string(digits));

        return number;
    }
}