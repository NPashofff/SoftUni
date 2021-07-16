using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Person
    {
        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persones = new List<Person>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] parts = input.Split();

                Person person = new Person()
                {
                    Age = int.Parse(parts[2]),
                    ID = parts[1],
                    Name = parts[0]

                };

                persones.Add(person);
            }

            persones = persones
                .OrderBy(x => x.Age)
                .ToList();

            foreach (var item in persones)
            {
                Console.WriteLine(item);
            }
        }
    }
}
