using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string[] input = Console.ReadLine()
                .Split()
                .ToArray();

            while (input[0] != "end")
            {
                if (input[0] == "exchange")
                {
                    int index = int.Parse(input[1]);


                    splitArr(arr, index);
                }

                input = Console.ReadLine()
                    .Split()
                    .ToArray();
                ;
            }

        }

        private static void splitArr(int[] arr, int index)
        {
            if (index < 0 || index > arr.Length)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            for (int j = 0; j <= index; j++)
            {
                int first = arr[0];

                for (int i = 1; i < arr.Length; i++)
                {
                    int preIndex = i - 1;
                    arr[preIndex] = arr[i];
                }

                arr[arr.Length - 1] = first;
            }
        }
    }
}
