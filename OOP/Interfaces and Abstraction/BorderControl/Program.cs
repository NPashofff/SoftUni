using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IBuyer> buyers = new List<IBuyer>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split();
                string name = parts[0];
                int age = int.Parse(parts[1]);

                if (parts.Length == 3)
                {
                    string group = parts[2];
                    Rebel rebel = new Rebel(name, age, group);
                    buyers.Add(rebel);
                }
                else if (parts.Length == 4)
                {
                    string id = parts[2];
                    string birthdate = parts[3];
                    Citizens citizen = new Citizens(name, age, id, birthdate);
                    buyers.Add(citizen);
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string name = input;
                foreach (var item in buyers)
                {
                    if (item.Name == name)
                    {
                        item.BuyFood();
                    }
                }

            }

            int sum = 0;
            foreach (var item in buyers)
            {
                sum += item.Food;
            }

            Console.WriteLine(sum);
           // string date = Console.ReadLine();

           // birthdates.Where(c => c.Birthdate.EndsWith(date))
           //.Select(c => c.Birthdate)
           //.ToList()
           //.ForEach(Console.WriteLine);

        }
    }
}
