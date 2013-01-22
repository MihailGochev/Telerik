using System;
using System.Linq;

class MaxSequence
{
    static void Main()
    {
        Random randomGenerator = new Random();
        int numberCount = 40;
        int[] numbers = new int[numberCount];

        Console.WriteLine("Input: ");
        for (int currentNumber = 0; currentNumber < numberCount; currentNumber++)
        {
            numbers[currentNumber] = randomGenerator.Next(-400, 200);
            Console.Write("{0,5}", numbers[currentNumber]);
        }
        Console.WriteLine();
        int maxSum = numbers[0];
        int currentSum = numbers[0];
        int startIndex = 0;
        int maxStartIndex = 0;
        int endIndex = 0;

        for (int currentNumber = 1; currentNumber < numbers.Length; currentNumber++)
        {
            currentSum += numbers[currentNumber];
            if (numbers[currentNumber] > currentSum)
            {
                currentSum = numbers[currentNumber];
                startIndex = currentNumber;
            }
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                maxStartIndex = startIndex;
                endIndex = currentNumber;
            }
        }

        if (endIndex < maxStartIndex)
        {
            endIndex = numbers.Length - 1;
        }

        Console.WriteLine("Output:");
        for (int currentNumber = maxStartIndex; currentNumber <= endIndex; currentNumber++)
        {
            Console.Write("{0,5}", numbers[currentNumber]);
        }
        Console.WriteLine();
        Console.WriteLine("Sum: {0}", maxSum);
    }
}

