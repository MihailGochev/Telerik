using System;

class FirstBiggerNumber
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 17, 8, 9, 10 };
        int result = CheckArray(array);

        if (result >= 0)
        {
            Console.WriteLine("The first number that is bigger than its neighbors is {0} at index {1}.", array[result], result);
        }
        else
        {
            Console.WriteLine("No element is bigger than its neighbors.");
        }
    }


    static int CheckArray(int[] array)
    {
        for (int index = 0; index < array.Length; index++)
        {
            if (CheckNeighbors(array, index))
            {
                return index;
            }
        }

        return -1;
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