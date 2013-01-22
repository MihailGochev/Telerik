using System;
using System.Linq;

class QuickSort
{
    static void Main()
    {
        string[] stringArray = { "Ivan", "Pesho", "Georgi", "Nikolay", "Spas", "Gerasim", "Anton", "Blagoy", "Todor" };
        Console.WriteLine("Unsorted array: ");
        for (int i = 0; i < stringArray.Length; i++)
        {
            Console.Write(stringArray[i] + " ");
        }

        Console.WriteLine();

        QSort(stringArray, 0, stringArray.Length - 1);

        Console.WriteLine("Sorted array: ");
        for (int i = 0; i < stringArray.Length; i++)
        {
            Console.Write(stringArray[i] + " ");
        }

        Console.WriteLine();
    }

    static void QSort(string[] elements, int left, int right)
    {
        int currentLeft = left;
        int currentRight = right;

        string median = elements[(left + right) / 2];

        while (currentLeft <= currentRight)
        {
            while (elements[currentLeft].CompareTo(median) < 0)
            {
                currentLeft++;
            }

            while (elements[currentRight].CompareTo(median) > 0)
            {
                currentRight--;
            }

            if (currentLeft <= currentRight)
            {
                string tmp = elements[currentLeft];
                elements[currentLeft] = elements[currentRight];
                elements[currentRight] = tmp;

                currentLeft++;
                currentRight--;
            }
        }

        if (left < currentRight)
        {
            QSort(elements, left, currentRight);
        }

        if (currentLeft < right)
        {
            QSort(elements, currentLeft, right);
        }
    }
}