using System;
using System.Linq;

class MaxSumOfKElements
{
    static void Main()
    {
        Random randomGenerator = new Random();
        int numberOfElements = randomGenerator.Next(10, 100);
        int maxSumCount = randomGenerator.Next(2, numberOfElements / 2);
        int currentSum = 0;
        int maxSum = 0;
        int maxSumStartIndex = 0;
        int[] numbers = new int[numberOfElements];

        Console.WriteLine("Sequence lenght {0}.", maxSumCount);
        Console.WriteLine("Input {0} numbers:", numberOfElements);
        for (int currentNumber = 0; currentNumber < numberOfElements; currentNumber++)
        {
            numbers[currentNumber] = randomGenerator.Next(0, 100);
            Console.Write(" {0}", numbers[currentNumber]);
        }

        for (int currentNum = 0; currentNum < maxSumCount; currentNum++)
        {
            currentSum += numbers[currentNum];
        }

        for (int currentNum = maxSumCount; currentNum < numberOfElements - maxSumCount - 1; currentNum++)
        {
            currentSum -= numbers[currentNum - maxSumCount];
            currentSum += numbers[currentNum + maxSumCount];
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                maxSumStartIndex = currentNum;
            }
            Console.Write(" {0}", numbers[currentNum]);
            currentSum += numbers[currentNum];
        }

        Console.WriteLine("\r\nMax sum of {0} elements is at index {1}: ", maxSumCount, maxSumStartIndex);
        for (int currentNum = maxSumCount; currentNum < maxSumCount + maxSumCount; currentNum++)
        {
            Console.Write("{0} ", numbers[currentNum]);
        }
        Console.WriteLine();
    }
}