using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> tascks = new Stack<int>(
                Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            
            Stack<int> threads = new Stack<int>
                (Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToArray());

            int valueOfTasck = int.Parse(Console.ReadLine());
            int tasck;
            int thred;

            while (true)
            {
                int tasckCurrent = tascks.Peek();
                int thredCurrent = threads.Peek();

                if (tasckCurrent == valueOfTasck)
                {
                    tasck = tascks.Pop();
                    thred = threads.Pop();
                    break;
                }
                else if (thredCurrent >= tasckCurrent)
                {
                    tasck = tascks.Pop();
                    thred = threads.Pop();
                }
                else
                {
                    while (threads.Count > 0)
                    {
                        if (tasckCurrent > thredCurrent)
                        {
                            threads.Pop();
                        }
                        else
                        {
                            tasck = tascks.Pop();
                            thred = threads.Pop();
                            break;
                        }

                        thredCurrent = threads.Peek();
                    }
                }
            }

            threads.Push(thred);
            Console.WriteLine($"Thread with value {thred} killed task {valueOfTasck}");
            Console.WriteLine(String.Join(" ", threads));
        }
    }
}
