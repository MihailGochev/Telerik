using System;

class CompareArray
{
    static void Main()
    {
        Console.Write("Please enter the lenght of the arrays: ");
        int numberOfElements = int.Parse(Console.ReadLine());
        int[] firstArray = new int[numberOfElements];
        int[] secondArray = new int[numberOfElements];

        Console.WriteLine("First array:");
        for (int element = 0; element < numberOfElements; element++)
        {
            Console.Write("{0} element: ", element + 1);
            firstArray[element] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Second array:");
        for (int element = 0; element < numberOfElements; element++)
        {
            Console.Write("{0} element: ", element + 1);
            secondArray[element] = int.Parse(Console.ReadLine());
        }

        for (int element = 0; element < numberOfElements; element++)
        {
            if (firstArray[element] > secondArray[element])
            {
                Console.WriteLine("element {0}: {1} > {2}", element + 1, firstArray[element], secondArray[element]);
            }
            else if (firstArray[element] < secondArray[element])
            {
                Console.WriteLine("element {0}: {1} < {2}", element + 1, firstArray[element], secondArray[element]);
            }
            else
            {
                Console.WriteLine("element {0}: {1} = {2}", element + 1, firstArray[element], secondArray[element]);
            }
        }
    }
}