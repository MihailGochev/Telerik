using System;
using System.Linq;
using System.Threading;

class ReadDate
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        string input = "07.12.2012 14:28:55";
        string[] inputSplit = input.Split(new char[] { ' ', ':', '.' });
        int day = int.Parse(inputSplit[0]);
        int month = int.Parse(inputSplit[1]);
        int year = int.Parse(inputSplit[2]);
        int hour = int.Parse(inputSplit[3]);
        int minute = int.Parse(inputSplit[4]);
        int second = int.Parse(inputSplit[5]);

        DateTime date = new DateTime(year, month, day, hour, minute, second);
        date = date.AddMinutes(390);

        Console.WriteLine("{0:dd.MM.yyyy hh:mm:ss MMMM}", date);
    }
}
