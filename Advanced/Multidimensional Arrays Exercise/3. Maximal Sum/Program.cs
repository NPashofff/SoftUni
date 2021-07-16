using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = InputMethod();
            int rol = input[0];
            int col = input[1];
            int[,] matrix = GetMatrix(rol, col);

            int bestSum = int.MinValue;
            int rolBest = 0;
            int colBest = 0;
            FindMaxMatrix(rol, col, matrix, ref bestSum, ref rolBest, ref colBest);

            Print(matrix, bestSum, rolBest, colBest);
        }

        private static void FindMaxMatrix(int rol, int col, int[,] matrix, ref int bestSum, ref int rolBest, ref int colBest)
        {
            for (int i = 0; i <= rol - 3; i++)
            {
                for (int j = 0; j <= col - 3; j++)
                {
                    int curentSum = 0;
                    for (int k = i; k < i + 3; k++)
                    {
                        for (int l = j; l < j + 3; l++)
                        {
                            curentSum += matrix[k, l];
                        }
                    }

                    if (curentSum > bestSum)
                    {
                        bestSum = curentSum;
                        rolBest = i;
                        colBest = j;
                    }
                }
            }
        }

        private static void Print(int[,] matrix, int bestSum, int rolBest, int colBest)
        {
            Console.WriteLine($"Sum = {bestSum}");

            for (int i = rolBest; i < rolBest + 3; i++)
            {
                for (int j = colBest; j < colBest + 3; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        private static int[] InputMethod()
        {
            return Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
        }

        private static int[,] GetMatrix(int rol, int col)
        {
            int[,] matrix = new int[rol, col];

            for (int i = 0; i < rol; i++)
            {
                int[] input = InputMethod();

                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            return matrix;
        }
    }
}
