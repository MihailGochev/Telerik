using System;
using System.Linq;
using System.Text;


class MatrixClass
{
    static void Main()
    {
        Matrix firstMatrix = new Matrix(new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } });
        Matrix secondMatrix = new Matrix(new int[,] { { 1, 2, 3 }, { 3, 4, 5 }, { 5, 6, 7 } });

        Console.WriteLine("First matrix: {0}", firstMatrix);
        Console.WriteLine("Second matrix: {0}", secondMatrix);


        Console.WriteLine("Addition:");
        Console.WriteLine(firstMatrix + secondMatrix);

        Console.WriteLine("Subtraction:");
        Console.WriteLine(firstMatrix - secondMatrix);

        Console.WriteLine("Multiplication:");
        Console.WriteLine(firstMatrix * secondMatrix);

    }
}


class Matrix
{
    public int Row;
    public int Col;
    private int[,] matrix;

    public Matrix()
    {
        this.matrix = new int[5, 5];
        this.Row = 5;
        this.Col = 5;
    }

    public Matrix(int row, int col)
    {
        this.matrix = new int[row, col];
        this.Row = row;
        this.Col = col;
    }

    public Matrix(int[,] matrix)
    {
        this.matrix = matrix;
        this.Row = matrix.GetLength(0);
        this.Col = matrix.GetLength(1);
    }

    public int this[int row, int col]
    {
        get
        {
            return matrix[row, col];
        }
        set
        {
            matrix[row, col] = value;
        }
    }

    public override string ToString()
    {
        StringBuilder elements = new StringBuilder();
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                elements.Append(string.Format("{0} ", matrix[row, col].ToString()));
            }
            elements.Append(Environment.NewLine);
        }
        return elements.ToString();
    }

    public static Matrix operator +(Matrix firstMatrix, Matrix secondMatrix)
    {
        Matrix resultMatrix = new Matrix(firstMatrix.Row, firstMatrix.Col);

        for (int row = 0; row < resultMatrix.Row; row++)
        {
            for (int col = 0; col < resultMatrix.Col; col++)
            {
                resultMatrix[row, col] = firstMatrix[row, col] + secondMatrix[row, col];
            }
        }

        return resultMatrix;
    }

    public static Matrix operator -(Matrix firstMatrix, Matrix secondMatrix)
    {
        Matrix resultMatrix = new Matrix(firstMatrix.Row, firstMatrix.Col);

        for (int row = 0; row < resultMatrix.Row; row++)
        {
            for (int col = 0; col < resultMatrix.Col; col++)
            {
                resultMatrix[row, col] = firstMatrix[row, col] - secondMatrix[row, col];
            }
        }
        return resultMatrix;
    }

    public static Matrix operator *(Matrix firstMatrix, Matrix secondMatrix)
    {
        Matrix resultMatrix = new Matrix(firstMatrix.Row, firstMatrix.Col);

        for (int resultRow = 0; resultRow < resultMatrix.Row; resultRow++)
        {
            for (int resultCol = 0; resultCol < resultMatrix.Col; resultCol++)
            {
                for (int index = 0; index < resultMatrix.Col; index++)
                {
                    resultMatrix[resultRow, resultCol] += firstMatrix[resultRow, index] * secondMatrix[index, resultCol];
                }
            }
        }

        return resultMatrix;
    }

}
