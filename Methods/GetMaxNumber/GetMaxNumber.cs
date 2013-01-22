using System;
using System.Linq;

class GetMaxNumber
{
    static void Main()
    {
        Console.WriteLine("Write the first number:");
        int first = int.Parse(Console.ReadLine());
        Console.WriteLine("Write the second number:");
        int second = int.Parse(Console.ReadLine());
        Console.WriteLine("Write the third number:");
        int third = int.Parse(Console.ReadLine());
        Console.WriteLine("The biggest number is: {0}",GetMax(GetMax(first,second),third));
    }

    static int GetMax(int first, int second)
    {
        return first > second ? first : second;
    }
}