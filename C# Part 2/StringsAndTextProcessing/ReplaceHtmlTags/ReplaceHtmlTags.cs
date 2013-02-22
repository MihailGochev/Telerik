using System;
using System.Linq;

class ReplaceHtmlTags
{
    static void Main(string[] args)
    {
        string input = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course.\n\rAlso visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        input = input.Replace("<a href=\"", "[URL=");
        input = input.Replace("\">", "]");
        input = input.Replace("</a>", "[/URL]");

        Console.WriteLine(input);
    }
}
