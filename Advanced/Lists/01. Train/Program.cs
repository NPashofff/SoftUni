using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            
            int capacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] arrInput = input.Split().ToArray();

                if (arrInput.Length == 2)
                {
                    int idx = int.Parse(arrInput[1]);
                    train.Add(idx);
                }
                else
                {
                    int idx = int.Parse(arrInput[0]);

                    for (int i = 0; i < train.Count; i++)
                    {

                        if (train[i] + idx <= capacity)
                        {
                            train[i] += idx;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", train));
        }
    }
}
