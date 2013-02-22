using System;
using System.Linq;

class CheckForLeapYear
{
    static void Main()
    {
        Console.WriteLine("Please enter the year:");
        int year = int.Parse(Console.ReadLine());

        DateTime date = new DateTime(year, 2, 28);
        date = date.AddDays(1);
        if (date.Day == 29)
        {
            Console.WriteLine("Leap year.");
        }
        else
        {
            Console.WriteLine("Not a leap year.");
        }
    }
}