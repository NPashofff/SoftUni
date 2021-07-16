using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] jagedArrey = new double[n][];
            FillingJaggedArrey(n, jagedArrey);
            Manipulator(n, jagedArrey);

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "End")
                {
                    break;
                }

                string comand = input[0];
                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);
                int value = int.Parse(input[3]);

                if (row < 0 || col < 0 || row >= n)
                {
                    continue;
                }

                if (jagedArrey[row].Length > col)
                {
                    if (comand == "Add")
                    {
                        jagedArrey[row][col] += value;
                    }
                    else
                    {
                        jagedArrey[row][col] -= value;
                    }
                }
            }

            Print(n, jagedArrey);
        }

        private static void Print(int n, double[][] jagedArrey)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < jagedArrey[i].Length; j++)
                {
                    Console.Write($"{jagedArrey[i][j]} ");
                }
                Console.WriteLine();
            }
        }

        private static void Manipulator(int n, double[][] jagedArrey)
        {
            for (int i = 0; i < n - 1; i++)
            {

                if (jagedArrey[i].Length == jagedArrey[i + 1].Length)
                {
                    for (int j = 0; j < jagedArrey[i].Length; j++)
                    {
                        jagedArrey[i][j] *= 2;
                        jagedArrey[i + 1][j] *= 2;
                    }
                }
                else
                {
                    for (int j = 0; j < jagedArrey[i].Length; j++)
                    {
                        jagedArrey[i][j] /= 2;

                    }

                    for (int k = 0; k < jagedArrey[i + 1].Length; k++)
                    {
                        jagedArrey[i + 1][k] /= 2;
                    }
                }

            }
        }

        private static void FillingJaggedArrey(int n, double[][] jagedArey)
        {
            for (int i = 0; i < n; i++)
            {
                double[] row = Console.ReadLine()
                    .Split()
                    .Select(double.Parse)
                    .ToArray();
                jagedArey[i] = new double[row.Length];

                for (int j = 0; j < row.Length; j++)
                {
                    jagedArey[i][j] = row[j];
                }
            }
        }
    }
}
