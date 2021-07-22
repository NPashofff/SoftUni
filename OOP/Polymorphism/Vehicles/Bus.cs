namespace Vehicles
{
    public class Bus : Vehicles
    {
        private const double increasedFuel = 1.4;
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public bool DriveFull(double distance)
        {
            double fullConsumption = FuelConsumption + increasedFuel;
            double tripFuel = fullConsumption * distance;

            if (tripFuel <= FuelQuantity)
            {
                FuelQuantity -= tripFuel;
                return true;
            }
            return false;
        }
    }
}
