using System;
using System.Linq;

class SequenceInMatrix
{
    static int maxLenght = 0;
    static string maxElement;
    static int currentLenght;
    static readonly int right = 0;
    static readonly int down = 1;
    static readonly int diagonal = 2;

    static void Main()
    {
        string[,] field = 
        {
            {"go", "go", "to", "to", "to", "ba"},
            {"lol", "go", "go", "to", "ba", "ba"},
            {"ba", "lol", "aa", "to", "go", "go"},
            {"ba", "go", "lol", "go", "go", "aa"},
            {"ba", "go", "go", "lol", "aa", "aa"},
        };

        PrintMatrix(field);

        for (int row = 0; row < field.GetLength(0); row++)
        {
            for (int col = 0; col < field.GetLength(1); col++)
            {
                currentLenght = 0;
                CheckElement(row, col, field, field[row, col], right);
                currentLenght = 0;
                CheckElement(row, col, field, field[row, col], down);
                currentLenght = 0;
                CheckElement(row, col, field, field[row, col], diagonal);

            }
        }
        Console.WriteLine("Max lenght: {0}.", maxLenght);
        for (int element = 0; element < maxLenght; element++)
        {
            Console.Write(" {0}", maxElement);
        }
        Console.WriteLine();
    }


    static void CheckElement(int row, int col, string[,] field, string value, int direction)
    {
        if (OutOfBounds(row, col, field) || field[row, col] != value)
        {
            if (currentLenght > maxLenght)
            {
                maxLenght = currentLenght;
                maxElement = value;
            }
            return;
        }

        currentLenght++;
        if (direction == right)
        {
            CheckElement(row, col + 1, field, field[row, col], right);

        }
        if (direction == down)
        {
            CheckElement(row + 1, col, field, field[row, col], down);

        }
        if (direction == diagonal)
        {
            CheckElement(row + 1, col + 1, field, field[row, col], diagonal);
        }

    }

    static bool OutOfBounds(int row, int col, string[,] field)
    {
        if (col < 0 || row < 0 || row > field.GetLength(0) - 1 || col > field.GetLength(1) - 1)
        {
            return true;
        }
        return false;
    }

    static void PrintMatrix(string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(" {0}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}