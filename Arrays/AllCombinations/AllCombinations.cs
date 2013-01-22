using System;
using System.Linq;

class AllCombination
{

    static void Main()
    {
        Console.WriteLine("Please enter N");
        int combinationLenght = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter K");
        int numberCount = int.Parse(Console.ReadLine());
        int[] numbers = new int[numberCount];

        Combinations(0, numbers, numberCount - 1, combinationLenght, 1);
    }

    static void Combinations(int index, int[] numbers, int maxIndex, int length, int nextNumber)
    {
        if (index > maxIndex)
        {
            Print(numbers);
        }
        else
        {
            for (int number = nextNumber; number <= length; number++)
            {
                numbers[index] = number;
                Combinations(index + 1, numbers, maxIndex, length, nextNumber++);
            }
        }
    }

    static void Print(int[] numbers)
    {
        for (int index = 0; index < numbers.Length; index++)
        {
            Console.Write(" {0}", numbers[index]);
        }
        Console.WriteLine();
    }
}