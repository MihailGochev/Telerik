using System;
using System.Linq;
using MatrixT.Library;

namespace MatrixT.Test
{
    class Test
    {
        static void Main()
        {

            //tests with int
            int[,] myDoubleMatrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] myDoubleMatrix2 = new int[3, 3] { { 7, 8, 9 }, { 4, 5, 6 }, { 1, 2, 3 } };

            Matrix<int> myMatrix = new Matrix<int>(myDoubleMatrix);
            Matrix<int> myMatrix2 = new Matrix<int>(myDoubleMatrix2);
            Matrix<int> myEmptyMatrix = new Matrix<int>(3, 3);
            Matrix<int> differentSizedMatrix = new Matrix<int>(); //default size 5x5. Used to show exceptions

            ////Same tests with decimal
            //decimal[,] myDoubleMatrix = new decimal[3, 3] { { 1.5M, 1.5M, 3.5M }, { 4, 5, 6 }, { 7, 8, 9 } };
            //decimal[,] myDoubleMatrix2 = new decimal[3, 3] { { 7, 8, 9 }, { 1.5M, 1.5M, 3.5M }, { 1, 2, 3 } };

            //Matrix<decimal> myMatrix = new Matrix<decimal>(myDoubleMatrix);
            //Matrix<decimal> myMatrix2 = new Matrix<decimal>(myDoubleMatrix2);
            //Matrix<decimal> myEmptyMatrix = new Matrix<decimal>(3, 3);
            //Matrix<decimal> differentSizedMatrix = new Matrix<decimal>(); //default size 5x5. Used to show exceptions

            ////Same tests with double
            //double[,] myDoubleMatrix = new double[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //double[,] myDoubleMatrix2 = new double[3, 3] { { 7, 8, 9 }, { 4, 5, 6 }, { 1, 2, 3 } };

            //Matrix<double> myMatrix = new Matrix<double>(myDoubleMatrix);
            //Matrix<double> myMatrix2 = new Matrix<double>(myDoubleMatrix2);
            //Matrix<double> myEmptyMatrix = new Matrix<double>(3, 3);
            //Matrix<double> differentSizedMatrix = new Matrix<double>(); //default size 5x5. Used to show exceptions

            Console.WriteLine();
            Console.WriteLine("Arithmetic operations:");
            Console.WriteLine("Sum of 2 matrices");
            Console.WriteLine(myMatrix + myMatrix2);

            Console.WriteLine("Subtraction of 2 matrices:");
            Console.WriteLine(myMatrix - myMatrix2);

            Console.WriteLine("Multiplication of 2 matrices:");
            Console.WriteLine(myMatrix * myMatrix2);

            Console.WriteLine("Printing a matrix using indexers and RowSize/ColSize property:");
            for (int row = 0; row < myMatrix.RowSize; row++)
            {
                for (int col = 0; col < myMatrix.ColSize; col++)
                {
                    Console.Write("{0} ", myMatrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.WriteLine("Using true overload for checking whether the matrix is empty or not");
            if (myMatrix)
            {
                Console.WriteLine(myMatrix);
            }
            else
            {
                Console.WriteLine("The matrix is empty!");
            }

            Console.WriteLine("Same check for an empty matrix:");
            if (myEmptyMatrix)
            {
                Console.WriteLine(myEmptyMatrix);
            }
            else
            {
                Console.WriteLine("The matrix is empty!");
            }

            ////Exceptions
            //myEmptyMatrix = myMatrix + differentSizedMatrix;
            //myEmptyMatrix = myMatrix - differentSizedMatrix;
            //myEmptyMatrix = myMatrix * differentSizedMatrix;
        }
    }
}
