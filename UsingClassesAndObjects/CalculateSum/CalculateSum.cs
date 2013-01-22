using System;
using System.Linq;

class CalculateSum
{
    static void Main()
    {
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

