using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] digits = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> numbers = new Stack<int>(digits);

            while (true)
            {
                string input = Console.ReadLine().ToLower();

                if (input == "end")
                {
                    break;
                }

                string[] tockens = input.Split();
                string command = tockens[0];

                if (command == "add")
                {
                    int first = int.Parse(tockens[1]);
                    int second = int.Parse(tockens[2]);

                    numbers.Push(first);
                    numbers.Push(second);
                }

                if (command == "remove")
                {
                    int count = int.Parse(tockens[1]);

                    if (count > numbers.Count)
                    {

                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }
            }

            int sum = 0;

            while (numbers.Count > 0)
            {
                sum += numbers.Pop();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
