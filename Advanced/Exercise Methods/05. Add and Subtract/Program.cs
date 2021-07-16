using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int sum = SumFirstAndSecond(first, second);
            int substract = SubstractThird(sum, third);

            Console.WriteLine(substract);
        }

        private static int SubstractThird(int sum, int third)
        {
            return sum - third;
        }

        private static int SumFirstAndSecond(int first, int second)
        {
            return first + second;
        }
    }
}
