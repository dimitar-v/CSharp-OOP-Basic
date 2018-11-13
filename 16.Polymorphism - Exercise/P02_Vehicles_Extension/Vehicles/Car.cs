namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double AIR_CONDITION_CONSUMPTION = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption , tankCapacity)
        {
            FuelConsumption += AIR_CONDITION_CONSUMPTION;
        }
    }
}
