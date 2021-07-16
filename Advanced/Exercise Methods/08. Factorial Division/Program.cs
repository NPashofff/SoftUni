using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = int.Parse(Console.ReadLine());
            double second = int.Parse(Console.ReadLine());

            double firstFactorial = CalculateFactorial(first);
            double secondFactorial = CalculateFactorial(second);

            double result = firstFactorial / secondFactorial;

            Console.WriteLine($"{result:f2}");
        }

        private static double CalculateFactorial(double num)
        {
            double factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
