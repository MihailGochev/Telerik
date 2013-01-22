using System;
using System.Linq;

class PrintRandomNumbers
{
    static void Main()
    {
        Random randomGenerator = new Random();

        for (int number = 0; number < 10; number++)
        {
            Console.WriteLine(randomGenerator.Next(100, 201));
        }
    }
}