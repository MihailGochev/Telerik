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
                currentLenght = 0;
                int?[,] clone = (int?[,])field.Clone();
                CheckElement(row, col, clone, clone[row, col]);
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
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(" {0,3}", matrix[j, i]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}