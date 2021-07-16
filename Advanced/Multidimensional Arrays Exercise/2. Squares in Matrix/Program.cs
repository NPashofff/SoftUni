using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rol = input[0];
            int col = input[1];

            string[,] matrix = GetMatrix(rol, col);

            int counter = GetCount(rol, col, matrix);

            Console.WriteLine(counter);
        }

        private static int GetCount(int rol, int col, string[,] matrix)
        {
            int counter = 0;
            for (int i = 0; i < rol -1; i++)
            {
                for (int j = 0; j < col - 1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1]
                        && matrix[i, j] == matrix[i + 1, j]
                        && matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        private static string[,] GetMatrix(int rol, int col)
        {
            string[,] matrix = new string[rol, col];

            for (int i = 0; i < rol; i++)
            {
                string[] input = Console.ReadLine().Split();

                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            return matrix;
        }
    }
}
