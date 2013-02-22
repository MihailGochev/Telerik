using System;
using System.Linq;

class MinMaxAvgSum
{
    static void Main()
    {
        int[] numbers = { 76, 512, 77, 2, 4, 7, 124, 7, 21, 44, 22, 66, 1, };
        Console.WriteLine("Min value: {0}", GetMinValue(numbers));
        Console.WriteLine("Max value: {0}", GetMaxValue(numbers));
        Console.WriteLine("Average value: {0}", GetAverageValue(numbers));
        Console.WriteLine("Sum: {0}", GetSum(numbers));
        Console.WriteLine("Product: {0}", GetProduct(numbers));
    }

    static int GetMinValue(int[] numbers)
    {
        return numbers.Min();
    }

    static int GetMaxValue(int[] numbers)
    {
        return numbers.Max();
    }

    static double GetAverageValue(int[] numbers)
    {
        return numbers.Average();
    }

    static long GetSum(int[] numbers)
    {
        return numbers.Sum();
    }

    static long GetProduct(int[] numbers)
    {
        long result = 1;
        foreach (var number in numbers)
        {
            result *= number;
        }
        return result;
    }

}

