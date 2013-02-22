using System;
using System.Linq;

class AllPermutations
{
    static void Main()
    {
        Console.WriteLine("Please enter the number count");
        int numberCount = int.Parse(Console.ReadLine());
        int[] numbers = new int[numberCount];
        for (int index = 0; index < numbers.Length; index++)
        {
            numbers[index] = index + 1;
        }
        Permutation(numbers.Length - 1, numbers);
    }

    static void Permutation(int position, int[] numbers)
    {
        if (position == 0)
        {
            Print(numbers);
        }
        else
        {
            for (int index = 0; index < position; index++)
            {
                numbers[position] ^= numbers[index];
                numbers[index] ^= numbers[position];
                numbers[position] ^= numbers[index];

                Permutation(position - 1, numbers);

                numbers[position] ^= numbers[index];
                numbers[index] ^= numbers[position];
                numbers[position] ^= numbers[index];
            }

            Permutation(position - 1, numbers);
        }
    }

    static void Print(int[] numbers)
    {
        for (int numberIndex = 0; numberIndex < numbers.Length; numberIndex++)
        {
            Console.Write(" {0}", numbers[numberIndex]);
        }
        Console.WriteLine();
    }
}
