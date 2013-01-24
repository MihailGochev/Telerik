using System;
using System.IO;
using System.Linq;

class FindSubMatrix
{
    static void Main()
    {
        StreamReader inputFile = new StreamReader(@"..\..\input.txt");

         int[,] matrix ={
 {3, 2,  5,   6,    7,  8},
 {6, 2,  7,   21,   66, 2},
 {6, 22, 66,  2,    1,  6},
 {3, 5,  500, 1,    1,  8},
 {6, 5,  1,   1,    1, 2},
 {7, 5,  1,   1000, 6,  1},
        };
        using (inputFile)
        {
            string input = inputFile.ReadLine();
            string[] line = input.Split(' ');
            matrix = new int[line.Length, line.Length];

            for (int index = 0; index < line.Length; index++)
			{
                matrix[index] = int.Parse(line[index]);
			}

            matrix = new int[input.Length,input.Length];
            for (int row = 0; row < input.Length; row++)
			{

			}
        }

        int subMatrixSize = 3;
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
