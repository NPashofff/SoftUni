using System;
using System.Linq;

namespace _8._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            FillMatrix(n, matrix);
            string[] bombs = Console.ReadLine().Split();

            for (int i = 0; i < bombs.Length; i++)
            {
                int[] coordinates = bombs[i]
                    .Split(",").Select(int.Parse).ToArray();
                int row = coordinates[0];
                int col = coordinates[1];
                IsIn(row, col, n);
                int bomb = matrix[row, col];

                if (matrix[row, col] > 0)
                {
                    for (int r = row - 1; r <= row + 1; r++)
                    {
                        for (int c = col - 1; c <= col + 1; c++)
                        {
                            if (IsIn(r, c, n))
                            {
                                if (matrix[r, c] <= 0)
                                {

                                }
                                else
                                {
                                    matrix[r, c] -= bomb;
                                }

                            }
                        }
                    }
                    matrix[row, col] = 0;
                }
                

            }

            int liveCell = 0;
            int cellSum = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        liveCell++;
                        cellSum += matrix[i, j];
                    }
                }
            }

            Print(n, matrix, liveCell, cellSum);
        }

        private static void Print(int n, int[,] matrix, int liveCell, int cellSum)
        {
            Console.WriteLine($"Alive cells: {liveCell}");
            Console.WriteLine($"Sum: {cellSum}");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        private static bool IsIn(int row, int col, int n)
        {
            if (row >= 0 && col >= 0 && row < n && col < n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void FillMatrix(int n, int[,] matrix)
        {
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                    .Split().Select(int.Parse).ToArray();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
        }
    }
}
