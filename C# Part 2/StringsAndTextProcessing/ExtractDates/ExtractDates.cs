using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

class ExtractDates
{
    static void Main()
    {
        string input = "12.12.2012 03.03.2010 09.09.2000 08.03.1900";

        foreach (Match date in Regex.Matches(input, @"\b\d{2}.\d{2}.\d{4}\b"))
        {
            DateTime currentDate;
            if (DateTime.TryParseExact(date.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out currentDate))
            {
                Console.WriteLine(currentDate.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
            }
        }
    }
}