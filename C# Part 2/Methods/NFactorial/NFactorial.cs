using System;
using System.Linq;
using System.Numerics;

class NFactorial
{
    static void Main()
    {
        int factorial = 100;
        BigInteger result = CalculateFactorial(factorial);

        Console.WriteLine(result);
    }

    static BigInteger CalculateFactorial(int factorial)
    {
        if (factorial <= 1)
        {
            return 1;
        }
        return factorial * CalculateFactorial(factorial - 1);
    }
}