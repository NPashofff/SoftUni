namespace Vehicles
{
    public class Car : Vehicles
    {
        private const double increased = 0.9;
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption => base.FuelConsumption + increased;
    }
}
