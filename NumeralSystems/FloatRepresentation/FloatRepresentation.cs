using System;
using System.Linq;

class FloatRepresentation
{
    static unsafe void Main(string[] args)
    {
        float lol = -27.25f;
        Console.WriteLine(Convert.ToString((long)&lol, 2));
    }
}
