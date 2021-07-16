using System;
using System.Linq;

namespace _08._Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            Func<int, int, int> comperator = (num1, num2) =>
            (num1 % 2 == 0 && num2 % 2 != 0) ? -1 :
            (num1 % 2 != 0 && num2 % 2 == 0) ? 1 :
            num1.CompareTo(num2);

            Array.Sort<int>(num, new Comparison<int>(comperator));
            Console.WriteLine(string.Join(" ", num));
        }
    }
}
