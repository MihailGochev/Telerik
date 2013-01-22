using System;

class Allocate20Arrays
{
    static void Main()
    {
        int[] multipliedNumbers = new int[20];

        for (int currentNumber = 0; currentNumber < multipliedNumbers.Length; currentNumber++)
        {
            multipliedNumbers[currentNumber] = currentNumber * 5;
            Console.WriteLine(multipliedNumbers[currentNumber]);
        }
    }
}
