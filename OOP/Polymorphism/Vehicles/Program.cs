using System;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double carFuelQuantity = double.Parse(carInput[1]);
            double carFuelConsumption = double.Parse(carInput[2]);
            double carTankCapacity = double.Parse(carInput[3]);
            Car car = new Car(carFuelQuantity, carFuelConsumption, carTankCapacity);

            string[] truckInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double truckFuelQuantity = double.Parse(truckInput[1]);
            double truckFuelConsumption = double.Parse(truckInput[2]);
            double truckTankCapacity = double.Parse(truckInput[3]);
            Truck truck = new Truck(truckFuelQuantity, truckFuelConsumption, truckTankCapacity);

            string[] busInput = Console.ReadLine()
              .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double busFuelQuantity = double.Parse(busInput[1]);
            double buskFuelConsumption = double.Parse(busInput[2]);
            double busTankCapacity = double.Parse(busInput[3]);
            Bus bus = new Bus(busFuelQuantity, buskFuelConsumption, busTankCapacity);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string comand = parts[0];
                string vechichle = parts[1];
                double value = double.Parse(parts[2]);

                if (vechichle == "Car")
                {
                    if (comand == "Drive")
                    {
                        if (car.Drive(value))
                        {
                        }
                        else
                        {
                            Console.WriteLine("Car needs refueling");
                        }
                    }
                    else
                    {
                        car.Refuel(value);
                    }
                }
                else if (vechichle == "Truck")
                {
                    if (comand == "Drive")
                    {
                        if (truck.Drive(value))
                        {
                        }
                        else
                        {
                            Console.WriteLine("Truck needs refueling");
                        }

                    }
                    else
                    {
                        truck.Refuel(value);
                    }
                }
                else if (vechichle == "Bus")
                {
                    if (comand == "DriveEmpty")
                    {
                        if (bus.Drive(value))
                        {
                        }
                        else
                        {
                            Console.WriteLine($"Bus needs refueling");
                        }
                    }
                    else if (comand == "Drive")
                    {
                        if (bus.DriveFull(value))
                        {
                            Console.WriteLine($"Bus travelled {value} km");
                        }
                        else
                        {
                            Console.WriteLine($"Bus needs refueling");
                        }
                    }
                    else
                    {
                        bus.Refuel(value);
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }
    }
}
