using System;
using System.Collections.Generic;
using System.Linq;

class DecimalToBinary
{
    static void Main()
    {
        int startNumber = 552;
        int number = startNumber;
        List<int> binaryNumber = new List<int>();

        while (number > 0)
        {
            binaryNumber.Add(number % 2);
            number = number / 2;
        }

        binaryNumber.Reverse();

        Console.Write("{0} in binary is: ", startNumber);
        for (int index = 0; index < binaryNumber.Count; index++)
        {
            Console.Write("{0}", binaryNumber[index]);
        }
        Console.WriteLine();
    }    
}