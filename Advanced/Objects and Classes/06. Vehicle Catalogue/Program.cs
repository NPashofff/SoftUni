using System;
using System.Collections.Generic;

namespace _06._Vehicle_Catalogue
{
    public class Vechicl
    {
        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int HorsePower { get; set; }

    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Vechicl> vechicles = new List<Vechicl>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] parts = input.Split();

                Vechicl currentVechicle = new Vechicl
                {
                    Type = parts[0],
                    Model = parts[1],
                    Color = parts[2],
                    HorsePower = int.Parse(parts[3])
                };

                vechicles.Add(currentVechicle);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Close the Catalogue")
                {
                    break;
                }

                Vechicl vechicle = GetVechicleByName(vechicles, input);

                Console.WriteLine($"Type: {vechicle.Type}");
                Console.WriteLine($"Model: {vechicle.Model}");
                Console.WriteLine($"Color: {vechicle.Color}");
                Console.WriteLine($"Horsepower: {vechicle.HorsePower}");
            }

            double carAvaragePower = GetAvaragePower(vechicles, "Car");
            double truckAvaragePower = GetAvaragePower(vechicles, "truck");

            Console.WriteLine($"Cars have average horsepower of: {carAvaragePower:f2}");
            Console.WriteLine($"Trucks have average horsepower of: {truckAvaragePower:f2}");
        }

        private static double GetAvaragePower(List<Vechicl> vechicles, string v)
        {
            double sum = 0;
            int cout = 0;
            foreach (var item in vechicles)
            {
                if (item.Type == v)
                {
                    sum += item.HorsePower;
                    cout++;
                }
            }

            sum /= cout;
            return sum;
        }

        private static Vechicl GetVechicleByName(List<Vechicl> vechicles, string vechicle)
        {
            foreach (var item in vechicles)
            {
                if (item.Model == vechicle)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
