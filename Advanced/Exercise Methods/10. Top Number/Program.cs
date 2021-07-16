using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int sum = Sumdigit(i);
                if (sum % 8 == 0)
                {
                    if (IsOddNumInside(i))
                    {
                        Console.WriteLine(i);
                    }  
                }
            }
        }

        private static bool IsOddNumInside(int i)
        {
            int n = i;
            while (n >= 0)
            {
                int curentNum = n % 10;
                if (curentNum % 2 != 0)
                {
                    return true;
                }
                
                n /= 10;
                if (n <= 0)
                {
                    break;
                }
            }

            return false;
        }

        private static int Sumdigit(int i)
        {
            int n = i;
            int sum = 0;
            for (int j = 0; j < n; j++)
            {
                int currentNum = i % 10;

                sum += currentNum;

                i /= 10;

                if (i == 0)
                {
                    break;
                }
            }

            return sum;
        }
    }
}
