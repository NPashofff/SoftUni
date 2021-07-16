using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
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
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (input[0] == "End")
                {
                    break;
                }


                if (input[0] == "Add")
                {
                    int num = int.Parse(input[1]);
                    numbers.Add(num);
                }
                else if (input[0] == "Insert")
                {
                    int num = int.Parse(input[1]);
                    int idx = int.Parse(input[2]);

                    if (idx < 0 || idx >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.Insert(idx,num);
                }
                else if (input[0] == "Remove")
                {
                    int idx = int.Parse(input[1]);
                    
                    if (idx < 0 || idx >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.RemoveAt(idx);
                }
                else if (input[0] == "Shift" && input[1] == "left")
                {
                    int count = int.Parse(input[2]);
                    for (int i = 0; i < count; i++)
                    {
                        int first = numbers[0];
                        numbers.RemoveAt(0);
                        numbers.Add(first);
                    }
                }
                else if (input[0] == "Shift" && input[1] == "right")
                {
                    int count = int.Parse(input[2]);
                    for (int i = 0; i < count; i++)
                    {
                        int last = numbers[numbers.Count - 1];
                        numbers.RemoveAt(numbers.Count - 1);
                        numbers.Insert(0,last);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
