namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double AIR_CONDITION_CONSUMPTION = 0.9;

        public Car(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption )
        {
            FuelConsumption += AIR_CONDITION_CONSUMPTION;
        }
    }
}
