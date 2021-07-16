using System;
using System.IO;

namespace _02_Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using StreamReader reader = new StreamReader("text.txt");
            using StreamWriter writer = new StreamWriter("../../../output.txt");
            int counter = 1;

            while (!reader.EndOfStream)
            {
                int leathers = 0;
                int punctuation = 0;
                string line = reader.ReadLine();
                char[] charArr = line.ToCharArray();

                foreach (var item in charArr)
                {
                    if (char.IsLetter(item))
                    {
                        leathers++;
                    }
                    else if (char.IsPunctuation(item))
                    {
                        punctuation++;
                    }
                }

                writer.WriteLine($"Line{counter}:{line} ({leathers})({punctuation})");
                counter++;
            }

        }
    }
}
