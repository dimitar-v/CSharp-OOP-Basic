namespace Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; private set; }
        public double FuelConsumption { get; protected set; }

        public string Drive(double distance)
        {
            var needFuel = distance * FuelConsumption;
            if (needFuel <= FuelQuantity)
            {
                FuelQuantity -= needFuel;
                return $"{GetType().Name} travelled {distance} km";
            }

            return $"{GetType().Name} needs refueling";
        }

        public virtual void Refuel(double amount)
            => FuelQuantity += amount;

        public override string ToString()
            => $"{GetType().Name}: {FuelQuantity:F2}";
    }
}
