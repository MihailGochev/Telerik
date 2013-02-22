using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        string input = "Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. :D";

        foreach (Match email in Regex.Matches(input, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
        {
            Console.WriteLine(email);
        }
    }
}