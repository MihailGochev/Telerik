using System;
using System.Linq;


class FindLargestArea
{
    static int maxLenght = 0;
    static int currentLenght;

    static void Main()
    {
        int?[,] field = 
        {
            {1, 3, 2, 2, 2, 4},
            {3, 3, 3, 2, 4, 4},
            {4, 3, 1, 2, 3, 3},
            {4, 3, 1, 3, 3, 1},
            {4, 3, 3, 3, 1, 1},
        };

        PrintMatrix(field);

        for (int row = 0; row < field.GetLength(0); row++)
        {
            for (int col = 0; col < field.GetLength(1); col++)
            {
                if (field[row, col] != null)
                {
                    CheckElement(row, col, field, field[row, col]);
                }
                currentLenght = 0;
            }
        }
        Console.WriteLine("Max lenght: {0}.", maxLenght);
    }


    static void CheckElement(int row, int col, int?[,] field, int? value)
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
        field[row, col] = null;

        CheckElement(row + 1, col, field, value);
        CheckElement(row, col + 1, field, value);
        CheckElement(row - 1, col, field, value);
        CheckElement(row, col - 1, field, value);
        ////Whether diagonals are concidered neighbors or not
        //CheckElement(row + 1, col - 1, field, value);
        //CheckElement(row + 1, col + 1, field, value);
        //CheckElement(row - 1, col + 1, field, value);
        //CheckElement(row - 1, col - 1, field, value);

    }

    static bool OutOfBounds(int row, int col, int?[,] field)
    {
        if (col < 0 || row < 0 || row > field.GetLength(0) - 1 || col > field.GetLength(1) - 1)
        {
            return true;
        }
        return false;
    }

    static void PrintMatrix(int?[,] matrix)
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