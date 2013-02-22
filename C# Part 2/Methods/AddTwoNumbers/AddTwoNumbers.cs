using System;
using System.Linq;

class AddTwoNumbers
{
    static void Main()
    {
        int[] firstNumber = { 2, 6, 2, 6 };
        int[] secondNumber = { 9, 9, 9, 9, 9, 9, 9, 9 };
        int[] result;

        result = AddNumbers(firstNumber, secondNumber);

        PrintResult(firstNumber, secondNumber, result);

    }

    static int[] AddNumbers(int[] firstNumber, int[] secondNumber)
    {
        int[] biggerNumber;
        int[] smallerNumber;

        if (firstNumber.Length > secondNumber.Length)
        {
            biggerNumber = firstNumber;
            smallerNumber = secondNumber;
        }
        else
        {
            biggerNumber = secondNumber;
            smallerNumber = firstNumber;
        }

        int[] result = new int[biggerNumber.Length + 1];

        for (int index = 0; index < biggerNumber.Length; index++)
        {
            if (index >= smallerNumber.Length)
            {
                result[index] = biggerNumber[index] + result[index];
            }
            else
            {
                result[index] = smallerNumber[index] + biggerNumber[index] + result[index];
            }
            if (result[index] > 9)
            {
                result[index] %= 10;
                result[index + 1]++;
            }

        }
        return result;
    }

    static void PrintResult(int[] firstNumber, int[] secondNumber, int[] result)
    {
        Console.WriteLine();

        for (int index = firstNumber.Length - 1; index >= 0; index--)
        {
            Console.Write(firstNumber[index]);
        }
        Console.WriteLine("\nPlus");

        for (int index = secondNumber.Length - 1; index >= 0; index--)
        {
            Console.Write(secondNumber[index]);
        }
        Console.WriteLine("\nEquals");

        for (int index = result.Length - 1; index >= 0; index--)
        {
            if (index != result.Length - 1 || result[index] != 0)
            {
                Console.Write(result[index]);
            }
        }
        Console.WriteLine();
    }
}

