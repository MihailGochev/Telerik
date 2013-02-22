using System;
using System.Linq;

class AddPolynomials
{
    static void Main()
    {
        int[] firstPolynomial = new int[] { 5, 0, 3 };
        int[] secondPolynomial = new int[] { 3, 5, 1 };

        int[] result = PolynomialSum(firstPolynomial, secondPolynomial);

        Console.Write("({0}x² + {1}x + {2}) + ", firstPolynomial[2], firstPolynomial[1], firstPolynomial[0]);
        Console.Write("({0}x² + {1}x + {2}) = ", secondPolynomial[2], secondPolynomial[1], secondPolynomial[0]);
        Console.WriteLine("({0}x² + {1}x + {2})", result[2], result[1], result[0]);
    }

    static int[] PolynomialSum(int[] first, int[] second)
    {
        int[] result = new int[first.Length];

        for (int element = 0; element < result.Length; element++)
        {
            result[element] = first[element] + second[element];
        }
        return result;
    }
}