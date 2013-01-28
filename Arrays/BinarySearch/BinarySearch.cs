using System;
using System.Linq;

class BinarySearchSortedArray
{
    static void Main()
    {
        int[] numbers = new int[100];
        int number = 16;
        Random randomGenerator = new Random();

        Console.WriteLine("Unsorted array:");

        for (int currentNumber = 0; currentNumber < numbers.Length; currentNumber++)
        {
            numbers[currentNumber] = randomGenerator.Next(-50, 50);
            Console.Write("{0,3} ", numbers[currentNumber]);
        }

        Console.WriteLine();

        Array.Sort(numbers);

        Console.WriteLine("Sorted array:");
        for (int currentNumber = 0; currentNumber < numbers.Length; currentNumber++)
        {
            Console.Write("{0,3} ", numbers[currentNumber]);
        }

        Console.WriteLine();

        int location = BinarySearch(numbers, number, 0, numbers.Length - 1);
        if (location < 0)
        {
            Console.WriteLine("Nothing Found.");
        }
        else
        {
            Console.WriteLine("The number {0} if found at position {1} .", number, location);
        }
    }

    static int BinarySearch(int[] numbers, int number, int minBorder, int maxBorder)
    {
        if (maxBorder < minBorder)
        {
            return -minBorder;
        }
        else
        {
            int median = (minBorder + maxBorder) / 2;

            if (numbers[median] > number)
            {
                return BinarySearch(numbers, number, minBorder, median - 1);
            }
            else if (numbers[median] < number)
            {
                return BinarySearch(numbers, number, median + 1, maxBorder);
            }
            else
            {
                return median;
            }
        }
    }
}