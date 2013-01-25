using System;
using System.Linq;

class Tasks
{
    static void Main()
    {
        MainMenu();
    }

    static void MainMenu()
    {
        Console.WriteLine("(1) Reverse digits of a number.");
        Console.WriteLine("(2) Calculate average of a sequence.");
        Console.WriteLine("(3) Solve a linear equation a*x + b = 0.");
        Console.WriteLine("(4) Exit.");
        Console.Write("Choice: ");
        while (true)
        {
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ReverseDecimalMenu();
                    return;
                case "2":
                    AverageOfSequenceMenu();
                    return;
                case "3":
                    SolveEquationMenu();
                    return;
                case "4":
                    return;
                default:
                    break;
            }
            Console.Write("Invalid choice, try again: ");
        }
    }

    static void ReverseDecimalMenu()
    {
        Console.Clear();
        Console.WriteLine("Please enter the number (non-negative):");
        decimal input = decimal.Parse(Console.ReadLine());

        while (input < 0)
        {
            Console.WriteLine("The number cannot be negative, try again:");
            input = decimal.Parse(Console.ReadLine());
        }

        Console.WriteLine("{0} reversed is: {1}", input, ReverseDecimal(input));
    }

    static decimal ReverseDecimal(decimal number)
    {
        char[] digits = number.ToString().ToCharArray();
        Array.Reverse(digits);
        number = decimal.Parse(new string(digits));

        return number;
    }

    static void AverageOfSequenceMenu()
    {
        Console.Clear();
        Console.WriteLine("Please enter the sequence of numbers (separated by space):");
        string input = Console.ReadLine();

        while (input == string.Empty)
        {
            Console.WriteLine("The sequence cannot be emtpy, try again:");
            input = Console.ReadLine();
        }

        string[] numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        decimal[] parsedNumbers = new decimal[numbers.Length];
        for (int index = 0; index < numbers.Length; index++)
        {
            parsedNumbers[index] = decimal.Parse(numbers[index]);
        }
        Console.WriteLine("The average of the sequence is {0}.", AverageOfSequence(parsedNumbers));
    }

    static decimal AverageOfSequence(decimal[] numbers)
    {
        return numbers.Average();
    }

    static void SolveEquationMenu()
    {
        Console.Clear();
        Console.WriteLine("Please enter A (not zero):");
        decimal a = decimal.Parse(Console.ReadLine());

        while (a == 0)
        {
            Console.WriteLine("A cannot be zero, try again:");
             a = decimal.Parse(Console.ReadLine());
        }
        Console.WriteLine("Please enter B:");
        decimal b = decimal.Parse(Console.ReadLine());

        Console.WriteLine("X = {0}", SolveEquation(a,b));
    }

    static decimal SolveEquation(decimal a, decimal b)
    {
        if (a == 0)
        {
            return 0;
        }
        return -b / a;
    }
}
