using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        int numberLenght = int.Parse(Console.ReadLine());
        string inputNumbers = Console.ReadLine();
        string[] inputNumbersArray = inputNumbers.Split();
        int[] numbers = new int[numberLenght];//
        bool[] visited = new bool[numberLenght];
        List<int> result = new List<int>(numberLenght);

        for (int i = 0; i < inputNumbersArray.Length; i++)
        {
            numbers[i] = int.Parse(inputNumbersArray[i]);
        }

        bool cycleFound = false;
        int cycleStartIndex = 0;
        int cycleEndIndex = 0;

        while (cycleStartIndex >= 0 && cycleEndIndex < numberLenght)
        {
            if (!visited[cycleStartIndex])
            {
                result.Add(cycleStartIndex);
                visited[cycleStartIndex] = true;
                cycleStartIndex = numbers[cycleStartIndex];
            }
            else
            {
                cycleFound = true;
                cycleEndIndex = cycleStartIndex;
                cycleStartIndex = cycleStartIndex;
                break;
            }
        }

        for (int i = 0; i < result.Count; i++)
        {
            if (i == cycleStartIndex && cycleFound)
            {
                Console.Write("{0}(", result[i]);
            }
            else
            {
                if (i == result.Count - 1)
                {
                    Console.Write("{0}", result[i]);
                }
                else
                {
                    Console.Write("{0} ", result[i]);
                }
            }
        }

        if (cycleFound)
        {
            Console.WriteLine(")");
        }
        else
        {
            Console.WriteLine();

        }
    }
}

