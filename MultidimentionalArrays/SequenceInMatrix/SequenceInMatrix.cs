using System;
using System.Linq;

class SequenceInMatrix
{
    static int maxLenght = 0;
    static int currentLenght;

    static void Main()
    {
        int[,] field = 
        {
            {3, 3, 2, 2, 2, 4},
            {5, 3, 3, 2, 4, 4},
            {4, 5, 1, 2, 3, 3},
            {4, 3, 5, 3, 3, 1},
            {4, 3, 3, 5, 1, 1},
        };

        PrintMatrix(field);

        for (int row = 0; row < field.GetLength(0); row++)
        {
            for (int col = 0; col < field.GetLength(1); col++)
            {
                currentLenght = 0;
            }
        }
        Console.WriteLine("Max lenght: {0}.", maxLenght);
    }


    static void CheckElement(int row, int col, int[,] field, int value)
    {
        if (OutOfBounds(row, col, field) || field[row, col] != value)
        {
            if (currentLenght > maxLenght)
            {
                maxLenght = currentLenght;
            }
            return;
        }

        currentLenght++;


    }

    static bool OutOfBounds(int row, int col, int[,] field)
    {
        if (col < 0 || row < 0 || row > field.GetLength(0) - 1 || col > field.GetLength(1) - 1)
        {
            return true;
        }
        return false;
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(" {0,3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}