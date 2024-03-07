using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4CSharp
{
    internal class MatrixByte
    {
        protected byte[,] ByteArray;
        protected uint n, m;
        protected int codeError;
        protected static int num_vec;

        public MatrixByte()
        {
            n = m = 1;
            ByteArray = new byte[n, m];
            codeError = 0;
            num_vec++;
        }

        public MatrixByte(uint rows, uint cols)
        {
            n = rows;
            m = cols;
            ByteArray = new byte[n, m];
            codeError = 0;
            num_vec++;
        }

        public MatrixByte(uint rows, uint cols, byte init)
        {
            n = rows;
            m = cols;
            ByteArray = new byte[n, m];
            codeError = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    ByteArray[i, j] = init;
                }
            }
            num_vec++;
        }

        ~MatrixByte()
        {
            Console.WriteLine("Destructor called.");
        }

        public void Input()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"Enter element at [{i},{j}]: ");
                    ByteArray[i, j] = byte.Parse(Console.ReadLine());
                }
            }
        }

        public void Output()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{ByteArray[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public void SetValue(byte value)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    ByteArray[i, j] = value;
                }
            }
        }

        public static int NumVec
        {
            get { return num_vec; }
        }

        public uint Rows
        {
            get { return n; }
        }

        public uint Cols
        {
            get { return m; }
        }

        public int CodeError
        {
            get { return codeError; }
            set { codeError = value; }
        }

        public byte this[int row, int col]
        {
            get
            {
                if (row < 0 || row >= n || col < 0 || col >= m)
                {
                    codeError = -1;
                    return 0;
                }
                else
                {
                    codeError = 0;
                    return ByteArray[row, col];
                }
            }

            set
            {
                if (row < 0 || row >= n || col < 0 || col >= m)
                    codeError = -1;
                else
                {
                    codeError = 0;
                    ByteArray[row, col] = value;
                }
            }
        }

        // Overloaded unary operators
        public static MatrixByte operator ++(MatrixByte matrix)
        {
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    matrix.ByteArray[i, j]++;
                }
            }
            return matrix;
        }

        public static MatrixByte operator --(MatrixByte matrix)
        {
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    matrix.ByteArray[i, j]--;
                }
            }
            return matrix;
        }

        public static bool operator true(MatrixByte matrix)
        {
            if (matrix.n == 0 || matrix.m == 0)
                return false;

            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    if (matrix.ByteArray[i, j] == 0)
                        return false;
                }
            }
            return true;
        }

        public static bool operator false(MatrixByte matrix)
        {
            if (matrix.n == 0 || matrix.m == 0)
                return true;

            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    if (matrix.ByteArray[i, j] != 0)
                        return false;
                }
            }
            return true;
        }

        public static bool operator !(MatrixByte matrix)
        {
            if (matrix.n == 0 || matrix.m == 0)
                return true;

            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    if (matrix.ByteArray[i, j] == 0)
                        return false;
                }
            }
            return true;
        }

        public static MatrixByte operator +(MatrixByte matrix1, MatrixByte matrix2)
        {
            MatrixByte result = new MatrixByte(matrix1.n, matrix1.m);
            if (matrix1.n != matrix2.n || matrix1.m != matrix2.m)
                return matrix1;

            for (int i = 0; i < matrix1.n; i++)
            {
                for (int j = 0; j < matrix1.m; j++)
                {
                    result.ByteArray[i, j] = (byte)(matrix1.ByteArray[i, j] + matrix2.ByteArray[i, j]);
                }
            }
            return result;
        }

        public static MatrixByte operator -(MatrixByte matrix1, MatrixByte matrix2)
        {
            MatrixByte result = new MatrixByte(matrix1.n, matrix1.m);
            if (matrix1.n != matrix2.n || matrix1.m != matrix2.m)
                return matrix1;

            for (int i = 0; i < matrix1.n; i++)
            {
                for (int j = 0; j < matrix1.m; j++)
                {
                    result.ByteArray[i, j] = (byte)(matrix1.ByteArray[i, j] - matrix2.ByteArray[i, j]);
                }
            }
            return result;
        }

        public static MatrixByte operator *(MatrixByte matrix1, MatrixByte matrix2)
        {
            if (matrix1.m != matrix2.n)
            {
                Console.WriteLine("Matrix dimensions are not compatible for multiplication.");
                return matrix1;
            }

            MatrixByte result = new MatrixByte(matrix1.n, matrix2.m);
            for (int i = 0; i < matrix1.n; i++)
            {
                for (int j = 0; j < matrix2.m; j++)
                {
                    for (int k = 0; k < matrix1.m; k++)
                    {
                        result.ByteArray[i, j] += (byte)(matrix1.ByteArray[i, k] * matrix2.ByteArray[k, j]);
                    }
                }
            }
            return result;
        }

        public static MatrixByte operator /(MatrixByte matrix1, MatrixByte matrix2)
        {
            if (matrix1.n != matrix2.n || matrix1.m != matrix2.m)
            {
                Console.WriteLine("Matrix dimensions must be the same for division.");
                return matrix1;
            }

            MatrixByte result = new MatrixByte(matrix1.n, matrix1.m);
            for (int i = 0; i < matrix1.n; i++)
            {
                for (int j = 0; j < matrix1.m; j++)
                {
                    if (matrix2.ByteArray[i, j] != 0)
                    {
                        result.ByteArray[i, j] = (byte)(matrix1.ByteArray[i, j] / matrix2.ByteArray[i, j]);
                    }
                    else
                    {
                        Console.WriteLine("Division by zero error.");
                        return matrix1;
                    }
                }
            }
            return result;
        }

        public static MatrixByte operator %(MatrixByte matrix1, MatrixByte matrix2)
        {
            if (matrix1.n != matrix2.n || matrix1.m != matrix2.m)
            {
                Console.WriteLine("Matrix dimensions must be the same for modulus operation.");
                return matrix1;
            }

            MatrixByte result = new MatrixByte(matrix1.n, matrix1.m);
            for (int i = 0; i < matrix1.n; i++)
            {
                for (int j = 0; j < matrix1.m; j++)
                {
                    if (matrix2.ByteArray[i, j] != 0)
                    {
                        result.ByteArray[i, j] = (byte)(matrix1.ByteArray[i, j] % matrix2.ByteArray[i, j]);
                    }
                    else
                    {
                        Console.WriteLine("Division by zero error.");
                        return matrix1;
                    }
                }
            }
            return result;
        }

        // Перевантаження бінарних операторів порівняння
        public static bool operator ==(MatrixByte matrix1, MatrixByte matrix2)
        {
            if (ReferenceEquals(matrix1, matrix2)) return true;
            if ((object)matrix1 == null || (object)matrix2 == null) return false;

            if (matrix1.n != matrix2.n || matrix1.m != matrix2.m) return false;

            for (int i = 0; i < matrix1.n; i++)
            {
                for (int j = 0; j < matrix1.m; j++)
                {
                    if (matrix1.ByteArray[i, j] != matrix2.ByteArray[i, j])
                        return false;
                }
            }
            return true;
        }

        public static bool operator !=(MatrixByte matrix1, MatrixByte matrix2)
        {
            return !(matrix1 == matrix2);
        }

        public static bool operator >(MatrixByte matrix1, MatrixByte matrix2)
        {
            if (matrix1.n != matrix2.n || matrix1.m != matrix2.m)
            {
                Console.WriteLine("Matrix dimensions must be the same for comparison.");
                return false;
            }

            for (int i = 0; i < matrix1.n; i++)
            {
                for (int j = 0; j < matrix1.m; j++)
                {
                    if (matrix1.ByteArray[i, j] <= matrix2.ByteArray[i, j])
                        return false;
                }
            }
            return true;
        }

        public static bool operator <(MatrixByte matrix1, MatrixByte matrix2)
        {
            if (matrix1.n != matrix2.n || matrix1.m != matrix2.m)
            {
                Console.WriteLine("Matrix dimensions must be the same for comparison.");
                return false;
            }

            for (int i = 0; i < matrix1.n; i++)
            {
                for (int j = 0; j < matrix1.m; j++)
                {
                    if (matrix1.ByteArray[i, j] >= matrix2.ByteArray[i, j])
                        return false;
                }
            }
            return true;
        }

        public static bool operator >=(MatrixByte matrix1, MatrixByte matrix2)
        {
            return (matrix1 > matrix2 || matrix1 == matrix2);
        }

        public static bool operator <=(MatrixByte matrix1, MatrixByte matrix2)
        {
            return (matrix1 < matrix2 || matrix1 == matrix2);
        }
    }
}
