using System;

class CountNumberAppearance
{
    static void Main()
    {
        int[] numberArray = new int[] { 1, 3, 76, 7, 2, 5, 7, 2, 3, 5, 6, 2, 4, 5, 2, 2, 3, 3, 521, 2421, 4, 2, 1, 2, 4, 4, 6 };
        int checkedNumber = 2421;

        Console.WriteLine("The number {0} appears {1} times.",checkedNumber, NumberCount(numberArray, checkedNumber));

    }

    static int NumberCount(int[] array, int number)
    {
        int count = 0;
        foreach (int num in array)
        {
            if (num == number)
            {
                count++;
            }
        }

        return count;
    }
}