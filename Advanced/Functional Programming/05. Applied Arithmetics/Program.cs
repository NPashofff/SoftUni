using System;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Action<int[]> printer = number => Console.WriteLine(string.Join(" ", num));

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                if (input == "add")
                {
                    num = ForEach(num, number => ++number);
                }
                else if (input == "multiply")
                {
                    num = ForEach(num, number => number * 2);
                }
                else if (input == "subtract")
                {
                    num = ForEach(num, number => --number);
                }
                else if (input == "print")
                {
                    printer(num);
                }

            }
        }
        public static int[] ForEach(int[] num, Func<int, int> func)
            => num.Select(number => func(number)).ToArray();
    }
}
