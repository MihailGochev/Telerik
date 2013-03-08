//Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.
using System;
using System.Text;

public static class Extensions
{
    public static StringBuilder Substring(this StringBuilder sb, int startIndex)
    {
        string sbAsString = sb.ToString();
        sbAsString = sbAsString.Substring(startIndex);
        return new StringBuilder(sbAsString);
    }

    public static StringBuilder Substring(this StringBuilder sb, int startIndex, int length)
    {
        string sbAsString = sb.ToString();
        sbAsString = sbAsString.Substring(startIndex, length);
        return new StringBuilder(sbAsString);
    }
}

class StringBuilderSubString
{
    static void Main()
    {
        StringBuilder test = new StringBuilder("This is a test string.");

        Console.WriteLine("The full string:");
        Console.WriteLine(test);
        Console.WriteLine("Called with start index:");
        Console.WriteLine(test.Substring(10));
        Console.WriteLine("Called with start index and lenght:");
        Console.WriteLine(test.Substring(10, 4));
    }
}
