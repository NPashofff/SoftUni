using System;
using System.IO;
using System.Linq;
using System.Text;


namespace _01_Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            using StreamReader reader = new StreamReader("text.txt");
            char[] charToReplace = { '-', ',', '.', '!', '?' };
            int counter = 0;

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if (line == null)
                {
                    break;
                }

                if (counter % 2 == 0)
                {
                    StringBuilder sb = new StringBuilder();
                    char[] charLine = line.ToCharArray();

                    for (int i = 0; i < charLine.Length; i++)
                    {
                        char curent = charLine[i];

                        if (charToReplace.Contains(curent))
                        {
                            curent = '@';
                        }

                        sb.Append(curent);
                    }

                    string curentLine = sb.ToString();
                    string[] arr = curentLine
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    for (int i = arr.Length - 1; i >= 0; i--)
                    {
                        Console.Write($"{arr[i]} ");
                    }
                    Console.WriteLine();
                }
                counter++;
            }
        }
    }
}
