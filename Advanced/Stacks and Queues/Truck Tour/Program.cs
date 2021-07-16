using System;
using System.Collections.Generic;
using System.Linq;

namespace Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int[]> pumps = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                pumps.Enqueue(input);
            }

            int idx = 0;

            while (true)
            {
                int totalFuel = 0;

                foreach (int[] item in pumps)
                {
                    int fuel = item[0];
                    int distance = item[1];

                    totalFuel += fuel - distance;

                    if (totalFuel < 0)
                    {
                        pumps.Enqueue(pumps.Dequeue());
                        idx++;
                        break;
                    }
                }

                if (totalFuel >=0)
                {
                    break;
                }
            }

            Console.WriteLine(idx);
        }
    }
}
