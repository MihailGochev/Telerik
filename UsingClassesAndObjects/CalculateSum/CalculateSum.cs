using System;
using System.Linq;

class CalculateSum
{
    static void Main()
    {
        Console.WriteLine("Please enter the number sequence (on a single line, separated by spaces):");
        string numbers = Console.ReadLine();
        Console.WriteLine("Sum: {0}", CalcSum(numbers));
    }

    static long CalcSum(string numbers)
    {
        long sum = 0;
        string[] splitNumbers = numbers.Split(' ');
        foreach (var num in splitNumbers)
        {
            sum += int.Parse(num);
        }
        return sum;
    }
}

