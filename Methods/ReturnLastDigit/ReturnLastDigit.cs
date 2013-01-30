using System;

class ReturnLastDigit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("The last digit of the number {0} is: {1}", number, LastDigitAsWord(number));
    }

    static string LastDigitAsWord(int number)
    {

        switch (number%10)
        {
            case 1:
                return "one";
            case 2:
                return "two";
            case 3:
                return "three";
            case 4:
                return "four";
            case 5:
                return "five";
            case 6:
                return "six";
            case 7:
                return "seven";
            case 8:
                return "eight";
            case 9:
                return "nine";
            case 0:
                return "zero";
            default:
                return "not a number";
        }
    }
}