using System;
using System.Dynamic;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int min = LockingForSmollest(first, second, third);

            Console.WriteLine(min);
        }

        private static int LockingForSmollest(int first, int second, int third)
        {
            int a = Math.Min(first, second);

            if (a > third)
            {
                return third;
            }
            else
            {
                return a;
            }
        }
    }
}
