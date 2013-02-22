using System;
using System.Linq;

class DaysBetweenDates
{
    static void Main()
    {
        string firstDate = "27.02.2006";
        string secondDate = "21.12.2012";
        string[] first = firstDate.Split('.');
        string[] second = secondDate.Split('.');

        DateTime dateOne = new DateTime(int.Parse(first[2]), int.Parse(first[1]), int.Parse(first[0]));
        DateTime dateTwo = new DateTime(int.Parse(second[2]), int.Parse(second[1]), int.Parse(second[0]));

        Console.WriteLine("Distance: {0} days", (dateTwo-dateOne).Days);
    }
}
