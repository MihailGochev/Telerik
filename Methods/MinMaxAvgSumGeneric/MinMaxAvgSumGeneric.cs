using System;
using System.Linq;

class MinMaxAvgSumGeneric
{
    static void Main()
    {
        decimal[] numbers = { 76, 222, 77, 2, 4, 7, 124, 7, 21, 44, 22, 66, 1, };
        Console.WriteLine("Min value: {0}", GetMinValue(numbers));
        Console.WriteLine("Max value: {0}", GetMaxValue(numbers));
        Console.WriteLine("Average value: {0}", GetAverageValue(numbers));
        Console.WriteLine("Sum: {0}", GetSum(numbers));
        Console.WriteLine("Product: {0}", GetProduct(numbers));
    }

    static T GetMinValue<T>(T[] numbers)
    {
        return numbers.Min();
    }

    static T GetMaxValue<T>(T[] numbers)
    {
        return numbers.Max();
    }

    static T GetAverageValue<T>(T[] numbers)
    {
        dynamic result = GetSum(numbers) / (dynamic)numbers.Length;
        return result;
    }

    static T GetSum<T>(T[] numbers)
    {
        dynamic result = 0;
        foreach (var number in numbers)
        {
            result += number;
        } return result;
    }

    static T GetProduct<T>(T[] numbers)
    {
        dynamic result = 1;
        foreach (var number in numbers)
        {
            result *= number;
        }
        return result;
    }

}

