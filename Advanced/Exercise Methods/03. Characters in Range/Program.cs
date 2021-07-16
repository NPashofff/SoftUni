using System;
using System.Linq;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            char start = first;
            char end = second;

            if (second < first)
            {
                start = second;
                end = first;
            }

            PrintSibolsBetwen(start, end);
        }

        private static void PrintSibolsBetwen(char start, char end)
        {
            for (char i = (char)(start + 1); i < end; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}

