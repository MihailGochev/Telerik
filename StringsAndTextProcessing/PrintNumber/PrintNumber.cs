using System;
using System.Linq;

class PrintNumber
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("{0,15}", inputNumber);
        Console.WriteLine("{0,15:X}", inputNumber);
        Console.WriteLine("{0,15:P}", inputNumber);
        Console.WriteLine("{0,15:E}", inputNumber);
    }
}
