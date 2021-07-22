namespace Vehicles
{
    using System;

    public abstract class Vehicles
    {
        private double fuelQuantity;

        protected Vehicles(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            if (fuelQuantity > tankCapacity)
            {
                fuelQuantity = 0;
            }

            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
        }

        public double FuelQuantity
        {
            get => fuelQuantity;
            protected set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Fuel must be a positive number");
                }
                else
                {
                    fuelQuantity = value;
                }
            }
        }

        public virtual double FuelConsumption { get; private set; }

        public double TankCapacity { get; set; }

        public virtual void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                if (FuelQuantity + liters > TankCapacity)
                {
                    Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                }
                else
                {
                    FuelQuantity += liters;
                }
            }
        }

        public virtual bool Drive(double distance)
        {
            if (FuelConsumption * distance <= FuelQuantity)
            {
                if (FuelConsumption * distance - FuelQuantity >= 0)
                {
                    FuelQuantity -= FuelConsumption * distance;
                    Console.WriteLine($"{GetType().Name} travelled {distance} km");
                    return true;
                }
                else
                {
                    return false;
                }                
            }            
            return false;
        }
    }
}
