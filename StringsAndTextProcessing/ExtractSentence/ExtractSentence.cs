using System;
using System.Linq;
using System.Text.RegularExpressions;

class ExtractSentence
{
    static void Main()
    {
        string input = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days. Some more test in.";
        string[] sentences = input.Split('.');

        foreach (var item in sentences)
        {
            if (Regex.Matches(item, @"\bin\b").Count > 0)
            {
                Console.WriteLine("{0}.", item.Trim());
            }
        }
    }
}

