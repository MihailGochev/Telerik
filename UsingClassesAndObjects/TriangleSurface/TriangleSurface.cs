using System;
using System.Linq;

class TriangleSurface
{
    static void Main()
    {
        int altitude = 12;
        int firstSide = 13;
        int secondSide = 14;
        int thirdSide = 15;
        short angle = 59;

        Console.WriteLine("1: {0}", CalculateTriangleSurface(secondSide, altitude));
        Console.WriteLine("2: {0}", CalculateTriangleSurface(firstSide, secondSide, thirdSide));
        Console.WriteLine("3: {0}", CalculateTriangleSurface(firstSide, thirdSide, angle));
    }

    static double CalculateTriangleSurface(int side, int altitude)
    {
        return side * altitude / 2.0;
    }

    static double CalculateTriangleSurface(int firstSide, int secondside, int thirdSide)
    {
        double semiperimeter = (firstSide + secondside + thirdSide) / 2.0;
        semiperimeter *= (semiperimeter - firstSide) * (semiperimeter - secondside) * (semiperimeter - thirdSide);
        return Math.Sqrt(semiperimeter);
    }

    static double CalculateTriangleSurface(int firstSide, int secondSide, short angle)
    {
        return (firstSide * secondSide * Math.Sin(angle * Math.PI / 180)) / 2;
    }
}
