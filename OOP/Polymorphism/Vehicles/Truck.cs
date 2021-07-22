using System;

namespace Vehicles
{
    public class Truck : Vehicles
    {
        private const double increased = 1.6;
        private const double fuelLoss = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption => base.FuelConsumption + increased;

        public override void Refuel(double liters)
        {
            if (liters >= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                if (liters + FuelQuantity > TankCapacity)
                {
                    Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                }
                else
                {
                    base.Refuel(liters * fuelLoss);
                }
            }
        }
    }
}
