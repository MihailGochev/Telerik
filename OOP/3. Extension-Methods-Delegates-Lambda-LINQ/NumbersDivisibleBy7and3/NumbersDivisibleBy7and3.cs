//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
using System;
using System.Collections.Generic;
using System.Linq;

class NumbersDivisibleBy7and3
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        for (int number = 0; number < 100; number++)
        {
            numbers.Add(number);
        }


        Console.WriteLine("All numbers:");
        foreach (var num in numbers)
        {
            Console.Write("{0} ",num);
        }
        Console.WriteLine();
        var foundNumbers = numbers.Where(num => num % 7 == 0 && num % 3 == 0);

        Console.WriteLine();
        Console.WriteLine("Found numbers using lambda expressions:");
        foreach (var num in foundNumbers)
        {
            Console.Write("{0} ", num);
        }
        Console.WriteLine();

        foundNumbers =
            from num in numbers
            where num % 7 == 0 && num % 3 == 0
            select num;

        Console.WriteLine();
        Console.WriteLine("Found numbers using LINQ query operators:");
        foreach (var num in foundNumbers)
        {
            Console.Write("{0} ", num);
        }
        Console.WriteLine();
    }
}
