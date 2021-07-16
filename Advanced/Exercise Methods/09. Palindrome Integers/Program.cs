using System;


namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                string isPalindrome = Palindrome(input);

                Console.WriteLine(isPalindrome);

                input = Console.ReadLine();
            }
        }

        private static string Palindrome(string input)
        {
            string reverse = ReversString(input);

            if (input == reverse)
            {
                return "true";
            }
            else
            {
                return "false";
            }
        }

        private static string ReversString(string input)
        {
            char[] cArray = input.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
    }
}
