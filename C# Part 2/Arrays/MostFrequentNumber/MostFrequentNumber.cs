using System;
using System.Linq;

class MostFrequentNumber
{
    static void Main()
    {
        int[] numbers = new int[200];
        Random randomGenerator = new Random();

        for (int currentNum = 0; currentNum < numbers.Length; currentNum++)
        {
            numbers[currentNum] = randomGenerator.Next(-20, 30);
        }

        // Array.Sort(numbers);

        int maxLenght = 0;
        int maxNumber = 0;
        int currentLenght = 0;
        int currentNumber = numbers[0];

        for (int currentNum = 1; currentNum < numbers.Length; currentNum++)
        {
            Console.Write("{0} ", numbers[currentNum]);
            if (currentNumber == numbers[currentNum])
            {
                currentLenght++;
                if (currentLenght > maxLenght)
                {
                    maxLenght = currentLenght;
                    maxNumber = currentNumber;
                }
            }
            else
            {
                currentNumber = numbers[currentNum];
                currentLenght = 1;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Most frequent number: {0}", maxNumber);
        Console.WriteLine("Found {0} times.", maxLenght);
    }
}