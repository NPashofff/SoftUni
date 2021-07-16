using System;

namespace _9._Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split();
            string[,] matrx = new string[n, n];
            int rowS = 0;
            int colS = 0;
            int coals = 0;
            int totalC = 0;
            bool isCoalInMatrix = true;
            bool isReachedEnd = false;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                for (int j = 0; j < n; j++)
                {
                    matrx[i, j] = input[j];

                    if (input[j] == "s")
                    {
                        rowS = i;
                        colS = j;
                    }
                    else if (input[j] == "c")
                    {
                        totalC++;
                    }
                }
            }

            Command(n, commands, matrx, ref rowS, ref colS, ref coals, ref totalC, ref isCoalInMatrix, ref isReachedEnd);

            if (!isCoalInMatrix)
            {
                Console.WriteLine($"You collected all coals! ({rowS}, {colS})");
            }
            else if (isReachedEnd)
            {
                Console.WriteLine($"Game over! ({rowS}, {colS})");
            }
            else
            {
                Console.WriteLine($"{totalC} coals left. ({rowS}, {colS})");
            }
        }

        private static void Command(int n, string[] commands, string[,] matrx, ref int rowS, ref int colS, ref int coals, ref int totalC, ref bool isCoalInMatrix, ref bool isReachedEnd)
        {
            foreach (var comand in commands)
            {
                if (comand == "up")
                {
                    if (IsInMatrix(rowS - 1, colS, n))
                    {
                        rowS--;
                    }
                }
                else if (comand == "down")
                {
                    if (IsInMatrix(rowS + 1, colS, n))
                    {
                        rowS++;
                    }
                }
                else if (comand == "left")
                {
                    if (IsInMatrix(rowS, colS - 1, n))
                    {
                        colS--;
                    }
                }
                else if (comand == "right")
                {
                    if (IsInMatrix(rowS, colS + 1, n))
                    {
                        colS++;
                    }
                }

                if (matrx[rowS, colS] == "c")
                {
                    coals++;
                    totalC--;
                    matrx[rowS, colS] = "*";
                }
                else if (matrx[rowS, colS] == "e")
                {
                    isReachedEnd = true;
                    break;
                }

                if (totalC == 0)
                {
                    isCoalInMatrix = false;
                    break;
                }
            }
        }

        private static bool IsInMatrix(int rowS, int colS, int n)
        {
            if (rowS >= 0 && rowS < n && colS >= 0 && colS < n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
