using System;
using System.Linq;

class FindElementInSortedArray
{
    static void Main()
    {
        int[] numbers = { 2, 25, 16, 151, 1000, 66, 3, 1, 77, 123, 11, 69, 772, 61 };
        int number = 70;

        Console.WriteLine("Unsorted array:");
        foreach (int num in numbers)
        {
            Console.WriteLine(" {0}", num);
        }
        Console.WriteLine();

        Array.Sort(numbers);

        Console.WriteLine("Sorted array:");
        foreach (int num in numbers)
        {
            Console.WriteLine(" {0}", num);
        }
        Console.WriteLine();

        int index = Array.BinarySearch(numbers, number);

        if (index > 0)
        {
            Console.WriteLine(numbers[index]);
        }
        else
        {
            Console.WriteLine(numbers[index * -1 - 2]);
        }

    }
}