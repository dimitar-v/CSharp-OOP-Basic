namespace Vehicles
{
    public class Bus : Vehicle
    {
        private const double AIR_CONDITION_CONSUMPTION = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            FuelConsumption += AIR_CONDITION_CONSUMPTION;
        }

        public string DriveEmpty(double distance)
            => this.Drive(distance, AIR_CONDITION_CONSUMPTION);
    }
}
