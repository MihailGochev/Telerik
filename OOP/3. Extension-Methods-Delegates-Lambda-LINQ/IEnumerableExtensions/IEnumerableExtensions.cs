//Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
using System;
using System.Collections.Generic;
using System.Linq;
//            return (T)Convert.ChangeType(Convert.ToDecimal((object)first) * Convert.ToDecimal((object)second), typeof(T));

public static class Extensions
{
    public static T CustomSum<T>(this IEnumerable<T> collection)
    {
        decimal result = 0;
        foreach (var element in collection)
        {
            result += Convert.ToDecimal((object)element);
        }
        return (T)Convert.ChangeType(result, typeof(T));
    }

    public static T CustomProduct<T>(this IEnumerable<T> collection)
    {
        decimal result = 1;
        foreach (var element in collection)
        {
            result *= Convert.ToDecimal((object)element);
        }
        return (T)Convert.ChangeType(result, typeof(T));
    }

    public static T CustomAverage<T>(this IEnumerable<T> collection)
    {
        decimal result = Convert.ToDecimal((object)collection.CustomSum());
        return (T)Convert.ChangeType(result / collection.Count(), typeof(T));
    }

    public static T CustomMin<T>(this IEnumerable<T> collection)
        where T : IComparable, new()
    {
        int counter = 0;
        T minValue = new T();
        foreach (var element in collection)
        {
            if (counter == 0)
            {
                minValue = element;
            }
            else if (minValue.CompareTo(element) > 0)
            {
                minValue = element;
            }
            counter++;
        }

        return minValue;
    }

    public static T CustomMax<T>(this IEnumerable<T> collection)
        where T : IComparable, new()
    {
        int counter = 0;
        T maxValue = new T();
        foreach (var element in collection)
        {
            if (counter == 0)
            {
                maxValue = element;
            }
            else if (maxValue.CompareTo(element) < 0)
            {
                maxValue = element;
            }
            counter++;
        }

        return maxValue;
    }

}


class IEnumerableExtensions
{
    static void Main()
    {
        List<int> myList = new List<int>() { 3, 5, 6, 7, 8, 51, 15 };
        Console.WriteLine("Input:");
        foreach (var num in myList)
        {
            Console.Write("{0} ", num);
        }

        Console.WriteLine();
        Console.WriteLine("Average:");
        Console.WriteLine(myList.CustomAverage());
        Console.WriteLine("Product:");
        Console.WriteLine(myList.CustomProduct());
        Console.WriteLine("Max:");
        Console.WriteLine(myList.CustomMax());
        Console.WriteLine("Min:");
        Console.WriteLine(myList.CustomMin());
        Console.WriteLine("Sum:");
        Console.WriteLine(myList.CustomSum());
    }
}
