using System;
using System.Linq;

namespace _02_Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> name = name => Console.WriteLine($"Sir {name}");
            Console.ReadLine().Split().ToList().ForEach(name);
        }
    }
}
