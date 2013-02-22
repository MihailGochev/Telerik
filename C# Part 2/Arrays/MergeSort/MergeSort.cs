using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 3, 66, 2, 7, 77, 23, 12, 631, 3218, 55 };

        Console.WriteLine("Start array:");

        foreach (int number in numbers)
        {
            Console.Write(" {0}", number);
        }

        Console.WriteLine();

        numbers = MSort(numbers);

        Console.WriteLine("Sorted array:");

        foreach (int number in numbers)
        {
            Console.Write(" {0}", number);
        }
        Console.WriteLine();
    }


    static int[] MSort(int[] numbers)
    {
        if (numbers.Length == 1)
        {
            return numbers;
        }

        int median = numbers.Length / 2;
        int[] leftSide = new int[median];

        for (int index = 0; index < median; index++)
        {
            leftSide[index] = numbers[index];
        }

        int[] rightSide = new int[numbers.Length - median];

        for (int index = 0; index < numbers.Length - median; index++)
        {
            rightSide[index] = numbers[index + median];
        }

        leftSide = MSort(leftSide);
        rightSide = MSort(rightSide);

        int left = 0;
        int right = 0;

        int[] sortedNumbers = new int[numbers.Length];

        for (int index = 0; index < numbers.Length; index++)
        {
            if (left < leftSide.Length && right < rightSide.Length)
            {
                if (leftSide[left] < rightSide[right])
                {
                    sortedNumbers[index] = leftSide[left++];
                }
                else
                {
                    sortedNumbers[index] = rightSide[right++];
                }
            }
            else
            {
                if (left < leftSide.Length)
                {
                    sortedNumbers[index] = leftSide[left++];
                }
                else
                {
                    sortedNumbers[index] = rightSide[right++];
                }
            }
        }
        return sortedNumbers;
    }
}
