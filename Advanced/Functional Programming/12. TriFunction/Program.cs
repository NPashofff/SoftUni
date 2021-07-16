using System;
using System.Linq;

namespace _12._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Func<string, int, bool> validator = (name, vlue) => name.ToCharArray()
            .Select(curChar => (int)curChar).Sum() >= number;

            Func<string[], int, Func<string, int, bool>, string> fondName =
                (colection, value, func) => colection.FirstOrDefault(name => func(name, value));

            Console.WriteLine(fondName(names, number, validator));
        }
    }
}
