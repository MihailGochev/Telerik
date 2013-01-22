using System;
using System.Linq;
using System.Collections.Generic;

class SubsetSums
{
    static long[] numbers;
    static long sum;
    static int answerCount = 0;

    static void Main()
    {
        Console.Write("Molq vyvedete sumata koqto tyrsite (S): ");
        sum = long.Parse(Console.ReadLine());

        Console.Write("Molq vyvedete broq chisla (N): ");
        int numberCount = int.Parse(Console.ReadLine());

        int[] index = new int[numberCount];
        numbers = new long[numberCount];

        Console.WriteLine("Molq vyvedete {0} chisla (po edno na red).", numberCount);
        for (int number = 0; number < numbers.Length; number++)
        {
            numbers[number] = long.Parse(Console.ReadLine());
        }

        for (int number = 1; number <= numberCount; number++)
        {
            Permutation(number - 1, index, 0, number);
        }
        Console.WriteLine("Broi resheniq: {0}", answerCount);
    }

    static void Permutation(int currentIndex, int[] index, int start, int numbersInCombination)
    {
        if (currentIndex == -1)
        {
            PrintResult(index, numbersInCombination);
        }
        else
        {
            for (int number = start; number < index.Length; number++)
            {
                index[currentIndex] = number;
                Permutation(currentIndex - 1, index, number + 1, numbersInCombination);
            }
        }
    }

    static void PrintResult(int[] index, int numbersInCombination)
    {
        List<long> result = new List<long>();
        long currentSum = 0;
        for (int number = 0; number < numbersInCombination; number++)
        {
            currentSum += numbers[index[number]];
            result.Add(numbers[index[number]]);
        }
        if (currentSum == sum)
        {
            Console.WriteLine("Result found: ");
            for (int number = 0; number < result.Count; number++)
            {
                Console.Write("{0} ", result[number]);
            }
            Console.WriteLine();
            answerCount++;
        }
    }
}