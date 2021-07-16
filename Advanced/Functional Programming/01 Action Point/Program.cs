using System;
using System.Linq;

namespace _01_Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> name = name => Console.WriteLine(name);
            Console.ReadLine().Split().ToList().ForEach(name);
        }
    }
}
