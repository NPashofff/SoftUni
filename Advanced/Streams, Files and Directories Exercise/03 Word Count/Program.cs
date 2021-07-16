using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            using StreamReader textReader = new StreamReader("text.txt");
            using StreamReader wordsReader = new StreamReader("words.txt");
            Dictionary<string, int> words = new Dictionary<string, int>();
            List<string> text = new List<string>();
            FillWords(wordsReader, words);

            while (!textReader.EndOfStream)
            {
                string input = textReader.ReadLine().ToLower();
                char[] charInput = input.ToArray();
                StringBuilder stringBuilder = new StringBuilder();

                foreach (var item in charInput)
                {
                    if (!char.IsPunctuation(item))
                    {
                        stringBuilder.Append(item);
                    }
                }

                input = stringBuilder.ToString();
                string[] curentText = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in curentText)
                {
                    if (words.ContainsKey(item))
                    {
                        words[item]++;
                    }
                }
            }

            //Ако искаш резултат в bin махни ../../../ 

            using StreamWriter actualResult = new StreamWriter("../../../actualResults.txt");

            foreach (var item in words)
            {
                actualResult.WriteLine($"{item.Key} - {item.Value}");
            }

            using StreamWriter expectedResult = new StreamWriter("../../../expectedResult.txt");

            foreach (var item in words.OrderByDescending(x => x.Value))
            {
                expectedResult.WriteLine($"{item.Key} - {item.Value}");
            }
        }

        private static void FillWords(StreamReader wordsReader, Dictionary<string, int> words)
        {
            while (!wordsReader.EndOfStream)
            {
                string word = wordsReader.ReadLine().ToLower();
                if (!words.ContainsKey(word))
                {
                    words.Add(word, 0);
                }
            }
        }
    }
}
