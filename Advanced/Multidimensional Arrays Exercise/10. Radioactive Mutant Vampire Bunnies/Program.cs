using System;
using System.Linq;

namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coordinates = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();
            int n = coordinates[0];
            int m = coordinates[1];
            char[,] matrix = new char[n, m];
            int rowP = 0;
            int colP = 0;
            FillMatrix(n, m, matrix, ref rowP, ref colP);
            char[] commands = Console.ReadLine().ToCharArray();
            bool win = false;
            bool lose = false;

            matrix[rowP, colP] = '.';
            foreach (char comand in commands)
            {
                if (comand == 'U')
                {
                    rowP--;
                }
                else if (comand == 'D')
                {
                    rowP++;
                }
                else if (comand == 'L')
                {
                    colP--;
                }
                else if (comand == 'R')
                {
                    colP++;
                }

                BunyMultiplier(n, m, matrix);

                if (rowP >= 0 && rowP < n && colP >= 0 && colP < m)
                {
                    if (matrix[rowP, colP] == 'B')
                    {
                        lose = true;
                        break;
                    }
                }
                else
                {
                    win = true;
                    break;
                }                
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }

            if (win)
            {
                if (rowP < 0)
                {
                    rowP++;
                }

                if (rowP >= n)
                {
                    rowP--;
                }

                if (colP < 0)
                {
                    colP++;
                }

                if (colP >= m)
                {
                    colP--;
                }
                Console.WriteLine($"won: {rowP} {colP}");
            }
            else if (lose)
            {
                Console.WriteLine($"dead: {rowP} {colP}");
            }

        }

        private static void BunyMultiplier(int n, int m, char[,] matrix)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] == 'B')
                    {
                        if (IsInIsB(matrix, i - 1, j, n, m))
                        {
                            matrix[i - 1, j] = 'c';
                        }

                        if (IsInIsB(matrix, i + 1, j, n, m))
                        {
                            matrix[i + 1, j] = 'c';
                        }

                        if (IsInIsB(matrix, i, j - 1, n, m))
                        {
                            matrix[i, j - 1] = 'c';
                        }

                        if (IsInIsB(matrix, i, j + 1, n, m))
                        {
                            matrix[i, j + 1] = 'c';
                        }
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] == 'c')
                    {
                        matrix[i, j] = 'B';
                    }
                }
            }
        }

        private static bool IsInIsB(char[,] matrix, int i, int j, int n, int m)
        {
            if (i >= 0 && i < n && j >= 0 && j < m)
            {
                if (matrix[i, j] != 'B')
                {
                    return true;
                }
                else
                {
                    return false;
                }
                //return true;
            }
            else
            {
                return false;
            }

        }

        private static void FillMatrix(int n, int m, char[,] matrix, ref int rowP, ref int colP)
        {
            for (int i = 0; i < n; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = input[j];

                    if (input[j] == 'P')
                    {
                        rowP = i;
                        colP = j;
                    }
                }
            }
        }
    }
}
