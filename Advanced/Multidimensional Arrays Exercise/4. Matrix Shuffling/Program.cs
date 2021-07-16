using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = InputMethod();
            int row = input[0];
            int col = input[1];
            string[,] matrix = GetMatrix(row, col);

            while (true)
            {
                string[] read = Console.ReadLine().Split(" ", 2);

                if (read[0] == "END")
                {
                    break;
                }
                else if (read[0] == "swap")
                {
                    string[] parts = read[1].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        

                    if (parts.Length != 4)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }

                    int firstRow = int.Parse(parts[0]);
                    int firstCol = int.Parse(parts[1]);
                    int secondRow = int.Parse(parts[2]);
                    int secondtCol = int.Parse(parts[3]);

                    if (firstRow >= 0 && firstRow < row &&
                        firstCol >= 0 && firstCol < col &&
                        secondRow >= 0 && secondRow < row &&
                        secondtCol >= 0 && secondtCol < col)
                    {
                        string temp = matrix[firstRow, firstCol];
                        matrix[firstRow, firstCol] = matrix[secondRow, secondtCol];
                        matrix[secondRow, secondtCol] = temp;

                        PintToConsole(row, col, matrix);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }            
        }

        private static void PintToConsole(int row, int col, string[,] matrix)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
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

        private static int[] InputMethod()
        {
            return Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
        }
    }
}
