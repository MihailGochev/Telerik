using System;
using System.Linq;

class SubtractAndMultiplyPolynomial
{
    struct Polynomial
    {


    }

    static void Main()
    {
        int[] firstPolynomial = new int[] { 5, 2, 3 };
        int[] secondPolynomial = new int[] { 3, 5, 1 };


        int[] result = PolynomialSubtraction(firstPolynomial, secondPolynomial);

        Console.Write("({0}x² + {1}x + {2}) - ", firstPolynomial[2], firstPolynomial[1], firstPolynomial[0]);
        Console.Write("({0}x² + {1}x + {2}) = ", secondPolynomial[2], secondPolynomial[1], secondPolynomial[0]);
        Console.WriteLine("({0}x² + {1}x + {2})", result[2], result[1], result[0]);

        result = PolynomialMultiplication(firstPolynomial, secondPolynomial);

        Console.Write("({0}x² + {1}x + {2}) * ", firstPolynomial[2], firstPolynomial[1], firstPolynomial[0]);
        Console.Write("({0}x² + {1}x + {2}) = ", secondPolynomial[2], secondPolynomial[1], secondPolynomial[0]);

        Console.WriteLine("({0}x4 + {1}x3 + {2}x² + {3}x + {4})", result[4], result[3], result[2], result[1], result[0]);
    } 

    static int[] PolynomialSubtraction(int[] first, int[] second)
    {
        int[] result = new int[first.Length];

        for (int element = 0; element < result.Length; element++)
        {
            result[element] = first[element] - second[element];
        }

        return result;
    }

    static int[] PolynomialMultiplication(int[] first, int[] second)
    {
        int[] result = new int[first.Length * 2];


        for (int index = 0; index < first.Length; index++)
        {
            for (int index2 = 0; index2 < second.Length; index2++)
            {
                result[index + index2] += (first[index] * second[index2]);
            }
        }

        return result;
    }
}