using System;
using System.Linq;

class AllWorkingDays
{
    static void Main()
    {
        int days = 100;
        DateTime startDate = DateTime.Now;
        DateTime endDate = startDate.AddDays(days);
        int workingDays = 0;

        for (DateTime date = startDate; date < endDate; date = date.AddDays(1))
        {
            if (!IsHoliday(date))
            {
                Console.WriteLine(date.ToString("dd/MM/yyyy"));
                workingDays++;
            }
        }
        Console.WriteLine("Working days found: {0}.", workingDays);
        Console.WriteLine("Holidays found: {0}.", days - workingDays);
    }


    static bool IsHoliday(DateTime date)
    {
        DateTime[] holidays = new[]
        {
            new DateTime(date.Year, 1, 1),
            new DateTime(date.Year, 3, 3),
            new DateTime(date.Year, 5, 1),
            new DateTime(date.Year, 5, 2),
            new DateTime(date.Year, 5, 6),
            new DateTime(date.Year, 5, 24),
            new DateTime(date.Year, 9, 22),
            new DateTime(date.Year, 12, 24),
            new DateTime(date.Year, 12, 25),
            new DateTime(date.Year, 12, 26),
            new DateTime(date.Year, 12, 31),
        };

        if (date.DayOfWeek.ToString() == "Sunday" || date.DayOfWeek.ToString() == "Saturday")
        {
            return true;
        }

        foreach (DateTime holiday in holidays)
        {
            if (date == holiday)
            {
                return true;
            }
        }

        return false;
    }
}