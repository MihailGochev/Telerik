using System;
using System.Linq;

class SortWithMethods
{
    static void Main()
    {
        int[] numberArray = { 6, 62, 65, 4126, 4, 261, 12, 66, 21, 424, 65125, 166, 221 };

        NumberSort(numberArray, ascending: true);

        for (int index = 0; index < numberArray.Length; index++)
        {
            Console.Write("{0} ", numberArray[index]);
        }
        Console.WriteLine();
    }

    static int FindMaxElement(int[] numberArray, int startIndex)
    {
        int result = int.MinValue;

        if (startIndex >= numberArray.Length)
        {
            return 0;
        }

        for (int index = startIndex; index < numberArray.Length; index++)
        {
            if (numberArray[index] > result)
            {
                result = numberArray[index];
            }
        }
        return result;
    }

    static int FindIndex(int[] numberArray, int number, int startIndex)
    {
        for (int index = startIndex; index < numberArray.Length; index++)
        {
            if (numberArray[index] == number)
            {
                return index;
            }
        }
        return 0;
    }

    static void NumberSort(int[] numberArray, bool ascending)
    {
        int maxElement;
        int maxIndex;
        for (int index = 0; index < numberArray.Length; index++)
        {
            maxElement = FindMaxElement(numberArray, index);
            maxIndex = FindIndex(numberArray, maxElement, index);
            if (numberArray[maxIndex] > numberArray[index])
            {
                numberArray[index] ^= numberArray[maxIndex];
                numberArray[maxIndex] ^= numberArray[index];
                numberArray[index] ^= numberArray[maxIndex];
            }
        }
        if (ascending)
        {
            Array.Reverse(numberArray);
        }
    }


}

