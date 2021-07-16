using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.ToLower();
            int vowels = CountingVowels(input);

            Console.WriteLine(vowels);
        }

        private static int CountingVowels(string input)
        {
            int couner = 0;

            foreach (var VARIABLE in input)
            {
                if (VARIABLE == 'a' ||
                     VARIABLE == 'e' ||
                     VARIABLE == 'i' ||
                     VARIABLE == 'o' ||
                     VARIABLE == 'u')
                {
                    couner++;
                }
            }

            return couner;
        }
    }
}
