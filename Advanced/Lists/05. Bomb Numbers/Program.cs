using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] bomb = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb[0])
                {
                    int idx = i - bomb[1];
                    int count = bomb[1] + bomb[1] + 1;

                    if (idx < 0)
                    {
                        idx = 0;
                    }
                    
                    if (count > numbers.Count - idx)
                    {
                        count = (numbers.Count ) - idx;
                    }

                    numbers.RemoveRange(idx, count);
                    i = 0;
                }
            }

            int sum = 0;

            foreach (var VARIABLE in numbers)
            {
                sum += VARIABLE;
            }

            Console.WriteLine(sum);
        }
    }
}
