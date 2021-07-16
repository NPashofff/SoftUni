using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Car[] cars = new Car[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelCost = double.Parse(input[2]);
                cars[i] = new Car(model, fuelAmount, fuelCost);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] tocken = input.Split();
                string model = tocken[1];
                double distance = double.Parse(tocken[2]);
                cars.Where(c => c.Model == model).ToList().ForEach(c => c.Drive(distance));

            }

            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Model} {item.Fuel:f2} {item.Traveld}");
            }
        }
    }
}
