using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                string[] comand = input.Split();

                if (comand.Length == 3)
                {
                    int idx = int.Parse(comand[1]);
                    int position = int.Parse(comand[2]);
                    numbers.Insert(position, idx);
                }
                else
                {
                    int idx = int.Parse(comand[1]);
                    
                    for (int i = 0; i < numbers.Count ; i++)
                    {
                        numbers.Remove(idx);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
