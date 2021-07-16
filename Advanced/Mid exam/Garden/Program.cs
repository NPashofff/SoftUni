using System;
using System.Linq;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] dimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int row = dimensions[0];
            int col = dimensions[1];
            int[,] matrix = new int[row, col];
            FillMatrix(row, col, matrix);

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Bloom Bloom Plow")
                {
                    break;
                }

                int[] rowCol = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int rowP = rowCol[0];
                int colP = rowCol[1];

                if (IsIn(row, col, rowP, colP))
                {                    
                    for (int i = 0; i < row; i++)
                    {
                        if (i == rowP)
                        {
                            continue;
                        }
                            matrix[i, colP]++;                        
                    }
                    for (int i = 0; i < col; i++)
                    {
                        matrix[rowP, i]++;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates.");
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }

        private static bool IsIn(int row, int col, int rowP, int colP)
        {
            return rowP >= 0 && rowP < row && colP >= 0 && colP < col;
        }

        private static void FillMatrix(int row, int col, int[,] matrix)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = 0;
                }
            }
        }
    }
}
