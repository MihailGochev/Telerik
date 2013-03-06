//Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 

namespace MatrixT.Library
{
    using System;
    using System.Text;
    using System.Linq;

    public class Matrix<T>
        where T : IComparable
    {

        private readonly int rowSize;
        private readonly int colSize;
        private readonly T[,] matrix;

        public int RowSize
        {
            get { return rowSize; }
        }

        public int ColSize
        {
            get { return colSize; }
        }

        public Matrix()
            : this(5, 5)//default size 5
        {
        }

        public Matrix(int row, int col)
        {
            this.matrix = new T[row, col];
            this.rowSize = row;
            this.colSize = col;
        }

        public Matrix(T[,] matrix)
        {
            this.matrix = matrix;
            this.rowSize = matrix.GetLength(0);
            this.colSize = matrix.GetLength(1);
        }

        //Implement an indexer this[row, col] to access the inner matrix cells.
        public T this[int row, int col]
        {
            get
            {
                if (row < 0 || row > rowSize || col < 0 || col > colSize)
                {
                    throw new IndexOutOfRangeException("The index was outside the bounds of the matrix.");
                }
                return matrix[row, col];
            }
            set
            {
                if (row < 0 || row > rowSize || col < 0 || col > colSize)
                {
                    throw new IndexOutOfRangeException("The index was outside the bounds of the matrix.");
                }
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

        //Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication. Throw an exception when the operation cannot be performed.
        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.RowSize != secondMatrix.RowSize || firstMatrix.ColSize != secondMatrix.ColSize)
            {
                throw new ArgumentException("The matrices have different dimensions");
            }

            Matrix<T> resultMatrix = new Matrix<T>(firstMatrix.rowSize, firstMatrix.colSize);

            for (int row = 0; row < resultMatrix.rowSize; row++)
            {
                for (int col = 0; col < resultMatrix.colSize; col++)
                {
                    resultMatrix[row, col] = SumGenerics(firstMatrix[row, col], secondMatrix[row, col]);
                }
            }

            return resultMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.RowSize != secondMatrix.RowSize || firstMatrix.ColSize != secondMatrix.ColSize)
            {
                throw new ArgumentException("The matrices have different dimensions");
            }

            Matrix<T> resultMatrix = new Matrix<T>(firstMatrix.rowSize, firstMatrix.colSize);

            for (int row = 0; row < resultMatrix.rowSize; row++)
            {
                for (int col = 0; col < resultMatrix.colSize; col++)
                {
                    resultMatrix[row, col] = SubtGenerics(firstMatrix[row, col], secondMatrix[row, col]);
                }
            }
            return resultMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.RowSize != secondMatrix.ColSize || firstMatrix.ColSize != secondMatrix.RowSize)
            {
                throw new ArgumentException("The matrices have incompatible dimensions");
            }

            Matrix<T> resultMatrix = new Matrix<T>(firstMatrix.rowSize, firstMatrix.colSize);

            for (int resultRow = 0; resultRow < resultMatrix.rowSize; resultRow++)
            {
                for (int resultCol = 0; resultCol < resultMatrix.colSize; resultCol++)
                {
                    for (int index = 0; index < resultMatrix.colSize; index++)
                    {
                        resultMatrix[resultRow, resultCol] = SumGenerics(resultMatrix[resultRow, resultCol], MultGenerics(firstMatrix[resultRow, index], secondMatrix[index, resultCol]));
                    }
                }
            }

            return resultMatrix;
        }

        //Methods for arithmetic operations with generics
        private static T SumGenerics(T first, T second)
        {
            return (T)Convert.ChangeType(Convert.ToDouble((object)first) + Convert.ToDouble((object)second), typeof(T));
        }

        private static T SubtGenerics(T first, T second)
        {
            return (T)Convert.ChangeType(Convert.ToDouble((object)first) - Convert.ToDouble((object)second), typeof(T));
        }

        private static T MultGenerics(T first, T second)
        {
            return (T)Convert.ChangeType(Convert.ToDouble((object)first) * Convert.ToDouble((object)second), typeof(T));
        }

        ///Implement the true operator (check for non-zero elements).
        public static bool operator true(Matrix<T> matrix)
        {

            for (int row = 0; row < matrix.rowSize; row++)
            {
                for (int col = 0; col < matrix.colSize; col++)
                {
                    if (matrix[row, col].CompareTo((T)Convert.ChangeType(0, typeof(T))) != 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator false(Matrix<T> matrix)
        {

            for (int row = 0; row < matrix.rowSize; row++)
            {
                for (int col = 0; col < matrix.colSize; col++)
                {
                    if (matrix[row, col].CompareTo((T)Convert.ChangeType(0, typeof(T))) != 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
