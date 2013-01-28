using System;
using System.Linq;

class SortArray
{
    static void Main()
    {
        Random randomGenerator = new Random();
        int numberOfElements = 20;
        int[] numbers = new int[numberOfElements];
        int[] sortedNumbers = new int[numberOfElements];
        int currentNum;
        int currentNumIndex = 0;

        Console.WriteLine("Input array: ");
        for (int currentElement = 0; currentElement < numberOfElements; currentElement++)
        {
            numbers[currentElement] = randomGenerator.Next(-200, 200);
            Console.Write(" {0}", numbers[currentElement]);
        }

        for (int currentElement = 0; currentElement < numberOfElements; currentElement++)
        {
            currentNum = int.MaxValue;
            for (int element = 0; element < numberOfElements; element++)
            {
                if (numbers[element] < currentNum)
                {
                    currentNum = numbers[element];
                    currentNumIndex = element;
                }
            }
            sortedNumbers[currentElement] = currentNum;
            numbers[currentNumIndex] = int.MaxValue;
        }
        Console.WriteLine("\r\nSorted array:");
        for (int currentElement = 0; currentElement < numberOfElements; currentElement++)
        {
            Console.Write(" {0}", sortedNumbers[currentElement]);
        }
        Console.WriteLine();
    }
}