using System;
using System.Collections.Generic;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<string> undo = new Stack<string>();
            string word = "";

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", 2);
                string command = input[0];

                if (command == "1")
                {
                    undo.Push(word);
                    word += input[1];  
                }
                else if (command == "2")
                {
                    int idx = int.Parse(input[1]);
                    undo.Push(word);
                    word = word.Remove(word.Length - idx);

                }
                else if (command == "3")
                {
                    int idx = int.Parse(input[1]);
                    Console.WriteLine(word[idx - 1]);
                }
                else if (command == "4")
                {
                    word = undo.Pop();
                }
            }
        }
    }
}
