using System;
using System.IO;
using System.Linq;

class FindSubMatrix
{
    static void Main()
    {
        StreamReader inputFile = new StreamReader(@"..\..\input.txt");
        int[,] matrix;

        using (inputFile)
        {
            int matriSize = int.Parse(inputFile.ReadLine());
            matrix = new int[matriSize, matriSize];
            string rows;
            string[] numbers;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                rows = inputFile.ReadLine();
                numbers = rows.Split(' ');
                for (int col = 0; col < numbers.Length; col++)
                {
                    matrix[row, col] = int.Parse(numbers[col]);
                }
            }
        }


        int subMatrixSize = 2;
        int maxSum = int.MinValue;

        for (int row = 0; row < (matrix.GetLength(0) - subMatrixSize) + 1; row++)
        {
            for (int col = 0; col < (matrix.GetLength(1) - subMatrixSize) + 1; col++)
            {
                int currentSum = GetSubMatrixSum(matrix, row, col, subMatrixSize);
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
        }

        Console.WriteLine("The max sum is: {0}", maxSum);
    }

    static int GetSubMatrixSum(int[,] matrix, int row, int col, int subMatrixSize)
    {
        int sum = 0;
        for (int currentRow = 0; currentRow < subMatrixSize; currentRow++)
        {
            for (int currentCol = 0; currentCol < subMatrixSize; currentCol++)
            {
                sum += matrix[row + currentRow, col + currentCol];
            }
        }
        return sum;
    }
}
