using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lenghts = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();
            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();
            FillHashSet(lenghts[0], first);
            FillHashSet(lenghts[1], second);

            foreach (var item in first)
            {
                if (second.Contains(item))
                {
                    Console.Write($"{item} ");
                }
            }
        }

        private static void FillHashSet(int lenghts, HashSet<int> first)
        {
            for (int i = 0; i < lenghts; i++)
            {
                int n = int.Parse(Console.ReadLine());
                first.Add(n);
            }
        }
    }
}
