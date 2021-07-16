using System;
using System.Linq;

namespace BoxOfT
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //Box<int> box = new Box<int>();

            //for (int i = 0; i < n; i++)
            //{
            //    int input = int.Parse(Console.ReadLine());

            //    box.Add(input);
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    int curr = box.Remove();
            //    Console.WriteLine($"{curr.GetType()}: {curr}");
            //}

            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
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


        private static void Swap(int[] arr, int firstIdx, int secondIdx)
        {
            int temp = arr[firstIdx];
            arr[firstIdx] = arr[secondIdx];
            arr[secondIdx] = temp;
        }
    
    }
}
