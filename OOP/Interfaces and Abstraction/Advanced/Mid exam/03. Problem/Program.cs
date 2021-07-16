using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            
            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (input[0] == "Stop")
                {
                    break;
                }

                if (input[0] == "Delete")
                {
                    int idx = int.Parse(input[1]) + 1;
                    if (idx > -1 && idx < words.Count)
                    {
                        words.RemoveAt(idx);
                    }
                }
                else if (input[0] == "Swap")
                {
                    int word1Index = -1;
                    int word2Index = -1;

                    for (int i = 0; i < words.Count; i++)
                    {
                        if (words[i] == input[1])
                        {
                            word1Index = i;
                        }
                        else if (words[i] == input[2])
                        {
                            word2Index = i;
                        }
                    }

                    if (word1Index > -1 && word1Index < words.Count
                        && word2Index > -1 && word2Index < words.Count)
                    {
                        string wordSave = words[word1Index];
                        words[word1Index] = words[word2Index];
                        words[word2Index] = wordSave;
                    }
                }
                else if (input[0] == "Put")
                {
                    int idx = int.Parse(input[2]);

                    if (idx > - 1 && idx < words.Count)
                    {
                        if (idx - 1 == words.Count -1)
                        {
                            words.Add(input[1]);
                        }
                        else
                        {
                            if (idx <= 0)
                            {
                                continue;
                            }
                            words.Insert(idx -1, input[1]);
                        }
                    }
                }
                else if (input[0] == "Sort")
                {
                    words.Sort();
                    words.Reverse();
                }
                else if (input[0] == "Replace")
                {
                    for (int i = 0; i < words.Count; i++)
                    {
                        if (words[i] == input[2])
                        {
                            words[i] = input[1];
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", words));
        }
    }
}
