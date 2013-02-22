using System;
using System.Linq;

class AllPrimeNumbers
{
    static void Main()
    {
        bool[] notPrime = new bool[10000000];
        notPrime[0] = true;
        notPrime[1] = true;
        for (int currentNum = 2; currentNum <= Math.Sqrt(notPrime.Length); currentNum++)
        {
            if (!notPrime[currentNum])
            {
                for (int j = currentNum * 2; j < notPrime.Length; j += currentNum)
                {
                    notPrime[j] = true;
                }
            }
        }
        Console.WriteLine("Done!");
        //for (int currentNum = 2; currentNum < 100000; currentNum++)
        //{
        //    Console.WriteLine("Is {0} prime: {1}", currentNum, notPrime[currentNum] ^ true);
        //}
    }
}