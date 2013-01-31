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

        int index = 0;
        bool cycleFound = false;
        int cycleStartIndex = 0;

        while (true)
        {

            if (numbers[index] < numbers.Length)
            {
                if (!visited[index])
                {
                    result.Add(index);
                    visited[index] = true;
                    index = numbers[index];
                }
                else
                {
                    cycleFound = true;
                    cycleStartIndex = index;
                    break;
                }

            }
            else
            {
                result.Add(index);
                break;
            }
        }


        for (int i = 0; i < result.Count; i++)
        {
            if (i == cycleStartIndex && cycleFound)
            {
                Console.Write("({0}", result[i]);
            }
            else
            {
                if (i == 0)
                {
                    Console.Write("{0}", result[i]);
                }
                else
                {
                    Console.Write(" {0}", result[i]);
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