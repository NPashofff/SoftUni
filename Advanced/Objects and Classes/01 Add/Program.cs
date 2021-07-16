using System;

namespace Objects_and_Classes___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = new string[]
            {
                "Excellent product.", 
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            string[] events = new string[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            string[] autors = new string[]
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            string[] cities = new string[]
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            int n = int.Parse(Console.ReadLine());
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
               int phrasesIdx = random.Next(0, phrases.Length);
               int eventIdx = random.Next(0, events.Length);
               int autorIdx = random.Next(0, autors.Length);
               int citiesIdx = random.Next(0, cities.Length);

               Console.WriteLine($"{phrases[phrasesIdx]} {events[eventIdx]} {autors[autorIdx]} – {cities[citiesIdx]}");
            }

        }
    }
}
