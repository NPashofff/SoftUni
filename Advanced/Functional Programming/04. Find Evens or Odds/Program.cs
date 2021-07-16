using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();
            string querry = Console.ReadLine();
            Predicate<int> predicate = querry == "odd"
                ? num => num % 2 != 0
                : new Predicate<int>( num => num % 2 == 0);            

            for (int i = bounds[0]; i <= bounds[1]; i++)
            {
                if (predicate(i))
                {
                    Console.Write($"{i} ");
                }
            }

        }
    }
}
