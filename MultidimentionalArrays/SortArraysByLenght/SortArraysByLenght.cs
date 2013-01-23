using System;
using System.Linq;

class SortArraysByLenght
{
    static void Main()
    {
        string[] strings = { "pesho", "ivan", "gerasim", "alexander", "ina", "dajsdjasdjadksk" };

        Array.Sort(strings,(s1, s2) => s1.Length.CompareTo(s2.Length));

        foreach (var str in strings)
        {
            Console.WriteLine(str);
        }
    }
}