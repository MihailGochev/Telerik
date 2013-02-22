using System;
using System.Linq;

class SequenceSum
{
    static void Main()
    {
        Random randomGenerator = new Random();
        int numberCount = 90;//RNG.Next(2, 300);
        int sum = 30;
        bool sumFound = false;
        Console.WriteLine("Sum = {0}", sum);
        int[] numbers = new int[numberCount];

        Console.WriteLine("Input: ");
        for (int number = 0; number < numberCount; number++)
        {
            if (number % 8 == 0)
            {
                Console.WriteLine();
            }
            numbers[number] = randomGenerator.Next(0, 15);
            Console.Write("{0,5}", numbers[number]);
        }

        int currentSum = 0;

        Console.WriteLine();
        for (int currentNumber = 0; currentNumber < numberCount; currentNumber++)
        {

            for (int element = currentNumber; element < numberCount; element++)
            {
                currentSum += numbers[element];
                if (currentSum == sum)
                {
                    Console.Write("Sum found: ");
                    sumFound = true;
                    for (int c = currentNumber; c <= element; c++)
                    {
                        Console.Write(" {0}", numbers[c]);
                    }
                    Console.WriteLine();
                    currentSum = 0;
                    break;
                }
                else if (currentSum > sum)
                {
                    currentSum = 0;
                    break;
                }
            }
        }

        if (!sumFound)
        {
            Console.WriteLine("No sequence was found.");
        }
    }
}