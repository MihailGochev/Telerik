using System;
using System.Linq;

class MaxIncreasingSequence
{

    static void Main()
    {
        Random randomGenerator = new Random();

        int[] numbers = new int[500];
        Console.WriteLine("Number sequence");
        for (int number = 0; number < numbers.Length; number++)
        {
            numbers[number] = randomGenerator.Next(0, 5);
            Console.Write("{0} ", numbers[number]);
        }
        Console.WriteLine();

        int maxLenght = 0;
        int maxNumber = 0;
        int maxNumberStart = 0;
        int currentLenght = 1;
        int currentNumber = numbers[0] + 1;


        for (int number = 1; number < numbers.Length; number++)
        {
            if (currentNumber == numbers[number])
            {
                currentLenght++;
                currentNumber++;
                if (currentLenght > maxLenght)
                {
                    maxLenght = currentLenght;
                    maxNumber = currentNumber - 1;
                    maxNumberStart = number;
                }
            }
            else
            {
                currentNumber = numbers[number] + 1;
                currentLenght = 1;
            }
        }

        Console.WriteLine("Max sequence start index:{0} Maximum number:{1}", maxNumberStart, maxNumber);
        Console.WriteLine("Number sequence:");

        for (int number = maxNumber - maxLenght + 1; number <= maxNumber; number++)
        {
            Console.Write("{0} ", number);
        }
        Console.WriteLine();
    }
}