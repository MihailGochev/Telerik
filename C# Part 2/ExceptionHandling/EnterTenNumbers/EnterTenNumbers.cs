using System;
using System.Linq;


class EnterTenNumbers
{
    static void Main()
    {
        int minValue = 1, maxValue = 100;

        for (int number = 0; number < 10; number++)
        {
            try
            {
                minValue = ReadNumber(minValue, maxValue);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The number was out of the specified range!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Number!");

            }
            catch (OverflowException)
            {
                Console.WriteLine("The number was too big!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No value was entered!");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("Not enough memory!");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Number!");
            }
        }
    }

    static int ReadNumber(int start, int end)
    {
        Console.WriteLine("Please enter a number in range [{0},{1}]", start, end);
        int number = int.Parse(Console.ReadLine());

        if (number < start || number > end)
        {
            throw new ArgumentOutOfRangeException();
        }

        return number;
    }

}