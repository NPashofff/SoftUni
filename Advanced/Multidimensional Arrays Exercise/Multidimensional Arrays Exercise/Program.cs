using System;
using System.Linq;

namespace Multidimensional_Arrays_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = NewMethod(n);

            int primaryDiagonal = 0;
            int secondarydiagonal = 0;

            for (int i = 0; i < n; i++)
            {
                primaryDiagonal += matrix[i, i];
                secondarydiagonal += matrix[n - i - 1, i];
            }

            Console.WriteLine(Math.Abs(primaryDiagonal - secondarydiagonal));
        }

        private static int[,] NewMethod(int n)
        {
            int[,] matrix = new int[n, n];

            for (int col = 0; col < n; col++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int rol = 0; rol < n; rol++)
                {
                    matrix[col, rol] = input[rol];
                }               
            }

            return matrix;
        }
    }
}
