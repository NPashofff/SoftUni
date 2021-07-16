using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> second = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            bool firstWin = false;
            bool secondWin = false;

            while (true)
            {
                if (first[0] > second[0])
                {
                    first.Add(first[0]);
                    first.Add(second[0]);
                    
                }
                else if (first[0] < second[0])
                {
                    second.Add(second[0]);
                    second.Add(first[0]);
                    
                }
                
                    second.RemoveAt(0);
                    first.RemoveAt(0);
                
                if (first.Count == 0)
                {
                    secondWin = true;
                    break;
                }

                if (second.Count == 0)
                {
                    firstWin = true;
                    break;
                }
            }

            int sum = 0;

            if (firstWin)
            {
                foreach (var i in first)
                {
                    sum += i;
                }

                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                foreach (var i in second)
                {
                    sum += i;
                }
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }


        }
    }
}
