using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Raw_Data
{
    public class StartUp
    {

        static void Main(string[] args)
        {
            var numberOfCars = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                var info = Console.ReadLine().Split();
                var engine = new Engine(int.Parse(info[1]), int.Parse(info[2]));
                var crgo = new Cargo(int.Parse(info[3]), info[4]);
                var tires = new Tires[]
                {
                    new Tires(double.Parse(info[5]),  int.Parse(info[6])),
                    new Tires(double.Parse(info[7]),  int.Parse(info[8])),
                    new Tires(double.Parse(info[9]),  int.Parse(info[10])),
                    new Tires(double.Parse(info[11]),  int.Parse(info[12]))
                };

                cars.Add(new Car(info[0], engine, crgo, tires));
            }

            string type = Console.ReadLine();
            var filtred = new List<Car>();

            if (type == "fragile")
            {
                filtred = cars.Where(c => c.Cargo.Type == "fragile"
                && c.Tires.Any(t => t.Pressure < 1)).ToList();
            }
            else
            {
                filtred = cars.Where(c => c.Cargo.Type == "flamable"
                && c.Engine.Power > 250).ToList();
            }

            foreach (var Car in filtred)
            {
                Console.WriteLine(Car.Model);
            }
        }
    }
}
