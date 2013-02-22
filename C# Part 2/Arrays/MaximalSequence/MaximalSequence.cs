using System;
using System.Linq;

class MaximalSequence
{
    static void Main()
    {
        Random randomGenerator = new Random();

        int[] numbers = new int[100];
        Console.WriteLine("Number sequence:");
        for (int number = 0; number < numbers.Length; number++)
        {
            numbers[number] = randomGenerator.Next(0, 5);
            Console.Write("{0} ", numbers[number]);
        }


        int maxLenght = 0;
        int maxNumber = 0;
        int maxNumberStart = 0;
        int currentLenght = 0;
        int currentNumber = numbers[0];


        for (int number = 1; number < numbers.Length; number++)
        {
            if (currentNumber == numbers[number])
            {
                currentLenght++;
            }
            else
            {
                if (currentLenght > maxLenght)
                {
                    maxLenght = currentLenght;
                    maxNumber = currentNumber;
                    maxNumberStart = number;
                }
                currentNumber = numbers[number];
                currentLenght = 1;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Maximal sequence, starting at index: {0}:", maxNumberStart);
        for (int number = 0; number < maxLenght; number++)
        {
            Console.Write("{0} ", maxNumber);
        }
        Console.WriteLine();
    }
}