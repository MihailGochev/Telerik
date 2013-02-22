using System;

class BiggerThanNeighbors
{
    static void Main()
    {
        int[] array = { 5, 2, 3, 4, 5, 6, 7, 8, 7, 9 };
        int index = 5;
        Console.WriteLine("Is {0} bigger than its neighbors: {1}", array[index], CheckNeighbors(array, index));
    }

    static bool CheckNeighbors(int[] array, int index)
    {
        if (index == 0)
        {
            if (array[index] > array[index + 1])
            {
                return true;
            }
        }
        else if (index == array.Length - 1)
        {
            if (array[index] > array[index - 1])
            {
                return true;
            }
        }
        else
        {
            if (array[index] > array[index - 1] && array[index] > array[index + 1])
            {
                return true;
            }
        }

        return false;
    }
}