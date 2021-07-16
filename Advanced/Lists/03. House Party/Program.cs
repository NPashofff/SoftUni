using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<string> names = new List<string>(num); 

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();
                
                if (input.Length == 3)
                {
                    bool isThere = true;

                    foreach (var VARIABLE in names)
                    {
                        if (VARIABLE == input[0])
                        {
                            Console.WriteLine($"{input[0]} is already in the list!");
                            isThere = false;
                            break;
                        }
                    }

                    if (isThere)
                    {
                        names.Add(input[0]);
                    }
                    
                }
                else
                {
                    bool isRemoved = names.Remove(input[0]);

                    if (!isRemoved)
                    {
                        Console.WriteLine($"{input[0]} is not in the list!");
                    }
                    
                }
            }

            Console.WriteLine(string.Join("\n", names));
        }
    }
}
