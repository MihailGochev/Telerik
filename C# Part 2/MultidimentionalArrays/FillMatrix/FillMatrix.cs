using System;
using System.Linq;


class FillMatrix
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];

        Console.WriteLine("Fill matrix (a):");
        FillMatrixA(matrix);

        Console.WriteLine("Fill matrix (b):");
        FillMatrixB(matrix);

        Console.WriteLine("Fill matrix (c):");
        FillMatrixC(matrix);

        Console.WriteLine("Fill matrix (d):");
        FillMatrixD(matrix);
    }





    static void FillMatrixA(int[,] matrix)
    {
        int currentIndex = 1;

        for (int row = 0; row < matrix.GetLength(1); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = currentIndex++;
            }
        }
        PrintMatrix(matrix);
    }

    static void FillMatrixB(int[,] matrix)
    {
        int currentIndex = 1;

        for (int row = 0; row < matrix.GetLength(1); row++)
        {
            if (row % 2 == 0)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentIndex++;
                }
            }
            else
            {
                for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                {
                    matrix[row, col] = currentIndex++;
                }
            }

        }
        PrintMatrix(matrix);
    }



    static void FillMatrixC(int[,] matrix)
    {
        int currentIndex = 1;
        int x = 0;
        int y = matrix.GetLength(0);

        while (currentIndex <= (matrix.GetLength(0) * matrix.GetLength(0)))
        {
            if (y > 0)
            {
                y--;
            }
            else if (y == 0)
            {
                x++;
            }
            currentIndex = WriteNumbers(matrix, currentIndex, x, y);
        }

        PrintMatrix(matrix);
    }



    static void FillMatrixD(int[,] matrix)
    {
        int row = 0;
        int col = 0;
        int lineLenght = matrix.GetLength(0);
        int counter = 1;

        for (int i = 1; i <= (matrix.GetLength(0) * matrix.GetLength(0)); i++)
        {
            matrix[row, col] = i;
            if (counter < lineLenght)
            {
                col++;
            }
            else if (counter < 2 * lineLenght - 1)
            {
                row++;
            }
            else if (counter < 3 * lineLenght - 2)
            {
                col--;
            }
            else if (counter < 4 * lineLenght - 4)
            {
                row--;
            }
            else
            {
                lineLenght -= 2;
                counter = 0;
                col++;
            }
            counter++;
        }

        PrintMatrix(matrix);
    }


    static int WriteNumbers(int[,] matrix, int currentIndex, int x, int y)
    {
        while (x < matrix.GetLength(1) && y < matrix.GetLength(1))
        {
            matrix[x++, y++] = currentIndex++;
        }
        return currentIndex;
    }


    static void PrintMatrix(int[,] matrix)
    {
        for (int col = 0; col < matrix.GetLength(0); col++)
        {
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                Console.Write(" {0,3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
