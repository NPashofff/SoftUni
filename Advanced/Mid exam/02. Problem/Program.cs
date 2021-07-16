using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cookies = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (input[0] == "Eat")
                {
                    break;
                }
                else if (input[0] == "Update-Any")
                {
                    for (int i = 0; i < cookies.Count; i++)
                    {
                        if (cookies[i] == input[1])
                        {
                            cookies[i] = "Out of stock";
                        }
                    }
                }
                else if (input[0] == "Remove")
                {
                    int idx = int.Parse(input[2]);
                    if (idx > -1 && idx < cookies.Count)
                    {
                        cookies[idx] = input[1];
                    }
                }
                else if (input[0] == "Update-Last")
                {
                    int lastCookies = cookies.Count - 1;
                    cookies[lastCookies] = input[1];
                }
                else if (input[0] == "Rearrange")
                {
                    for (int i = 0; i < cookies.Count; i++)
                    {
                        if (cookies[i].Contains(input[1]))
                        {
                            cookies.RemoveAt(i);
                            cookies.Add(input[1]);
                        }
                    }
                }

            }

            foreach (var VARIABLE in cookies)
            {
                if (VARIABLE != "Out of stock")
                {
                    Console.Write(VARIABLE + " ");
                }
            }
        }
    }
}
