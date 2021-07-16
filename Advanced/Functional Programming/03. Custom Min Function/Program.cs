using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> min = x => x.Min();
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(min(n));
        }
    }
}
