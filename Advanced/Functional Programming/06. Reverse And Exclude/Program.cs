using System;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int divisibleNumber = int.Parse(Console.ReadLine());
            Predicate<int> filter = num => num % divisibleNumber != 0;
            Action<int[]> printer = number => Console.WriteLine(string.Join(" ", 
                num.Reverse().Where(x => filter(x))));
            printer(num);
        }
    }
}
