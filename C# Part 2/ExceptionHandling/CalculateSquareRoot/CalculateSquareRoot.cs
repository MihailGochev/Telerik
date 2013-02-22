using System;
using System.Linq;

class CalculateSquareRoot
{
    static void Main()
    {
        decimal number;
        Console.Write("Please enter the number: ");
        try
        {
            number = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Square root of {0} is {1}.", number, Math.Sqrt((double)number));
        }
        catch (FormatException)
        {
            Console.WriteLine("Number was not in the valid format!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number was too big!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Null!");
        }
        finally
        {
            Console.WriteLine("Goodbye!");
        }
    }
}
