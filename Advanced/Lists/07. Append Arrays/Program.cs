using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split("|",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();


            ;
        }
    }
}
