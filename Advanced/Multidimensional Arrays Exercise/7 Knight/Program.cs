using System;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] board = new char[n, n];
            FillBoard(n, board);
            int removedK = 0;
            bool stop = true;

            while (stop)
            {
                int atacks = 0;
                int maxAtack = 0;
                int maxRow = 0;
                int maxCol = 0;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        atacks = 0;

                        if (IsIn(i - 2, j - 1, n))
                        {
                            if (board[i - 2, j - 1] == 'K')
                            {
                                atacks++;
                            }
                        }

                        if (IsIn(i - 2, j + 1, n))
                        {
                            if (board[i - 2, j + 1] == 'K')
                            {
                                atacks++;
                            }
                        }

                        if (IsIn(i + 2, j - 1, n))
                        {
                            if (board[i + 2, j - 1] == 'K')
                            {
                                atacks++;
                            }
                        }

                        if (IsIn(i + 2, j + 1, n))
                        {
                            if (board[i + 2, j + 1] == 'K')
                            {
                                atacks++;
                            }
                        }

                        if (IsIn(i - 1, j - 2, n))
                        {
                            if (board[i - 1, j - 2] == 'K')
                            {
                                atacks++;
                            }
                        }

                        if (IsIn(i + 1, j - 2, n))
                        {
                            if (board[i + 1, j - 2] == 'K')
                            {
                                atacks++;
                            }
                        }

                        if (IsIn(i - 1, j + 2, n))
                        {
                            if (board[i - 1, j + 2] == 'K')
                            {
                                atacks++;
                            }
                        }

                        if (IsIn(i + 1, j + 2, n))
                        {
                            if (board[i + 1, j + 2] == 'K')
                            {
                                atacks++;
                            }
                        }

                        if (atacks > maxAtack)
                        {
                            maxAtack = atacks;
                            maxRow = i;
                            maxCol = j;
                        }
                    }
                }

                if (maxAtack == 0)
                {
                    stop = false;
                }
                else
                {
                    board[maxRow, maxCol] = '0';
                    removedK++;
                }
            }

            Console.WriteLine(removedK);
        }


        private static bool IsIn(int v1, int v2, int n)
        {
            if (v1 > 0 && v1 < n && v2 > 0 && v2 < n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void FillBoard(int n, char[,] board)
        {
            for (int i = 0; i < n; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int j = 0; j < n; j++)
                {
                    board[i, j] = input[j];
                }
            }
        }
    }
}
