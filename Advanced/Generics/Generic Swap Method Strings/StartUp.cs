using System;
using System.Linq;

namespace Generic_Swap_Method_Strings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                arr[i] = input;
            }

            int[] comand = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int firstIdx = comand[0];
            int secondIdx = comand[1];
            Swap(arr, firstIdx, secondIdx);

            foreach (var item in arr)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }


        private static void Swap(string[] arr, int firstIdx, int secondIdx)
        {
            string bin = arr[firstIdx];
            arr[firstIdx] = arr[secondIdx];
            arr[secondIdx] = bin;
        }

    }

}
