using System;

namespace DefiningClasses
{
    public class Car
    {
        public string  Model { get; set; }
        public double Fuel { get; set; }
        public double Consumation { get; set; }
        public double Traveld { get; set; }

        public Car(string model, double fuel, double consumation)
        {
            Model = model;
            Fuel = fuel;
            Consumation = consumation;
            Traveld = 0;
        }

        public void Drive(double distance)
        {
            double fuelNeedet = distance * Consumation;

            if (Fuel >= fuelNeedet)
            {
                Fuel -= fuelNeedet;
                Traveld += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
