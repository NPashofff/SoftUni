using System;
using System.Linq;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string midle = PrintMiddleCar(input);

            Console.WriteLine(midle);
        }

        private static string PrintMiddleCar(string input)
        {
            if (input.Length % 2 == 0)
            {
                return $"{input[input.Length / 2 - 1]}{input[input.Length / 2]}";
            }
            else
            {
                return $"{input[input.Length / 2]}";
            }
        }
    }
}
