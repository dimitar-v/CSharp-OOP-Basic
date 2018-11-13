using System;

namespace Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        private double fuelQuantity;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
        }

        public double FuelQuantity
        {
            get => fuelQuantity;
            protected set
            {
                if (value > TankCapacity)
                {
                    fuelQuantity = 0;
                }
                else
                {
                    fuelQuantity = value;
                }
            }
        }
        public double FuelConsumption { get; protected set; }
        public double TankCapacity { get; }

        public string Drive(double distance)
            => Drive(distance, 0);

        public string Drive(double distance, double thurnedOfAirCondition)
        {
            var needFuel = distance * (FuelConsumption - thurnedOfAirCondition);
            if (needFuel <= FuelQuantity)
            {
                FuelQuantity -= needFuel;
                return $"{GetType().Name} travelled {distance} km";
            }

            return $"{GetType().Name} needs refueling";
        }

        public virtual void Refuel(double amount)
        {
            if (amount <= 0)
            {
                ArgumentException("Fuel must be a positive number");
            }

            if (amount + FuelQuantity > TankCapacity) // amount + FuelQuantity
            {
                ArgumentException($"Cannot fit {amount} fuel in the tank");
            }

            FuelQuantity += amount;
        }

        private void ArgumentException(string message)
            => throw new ArgumentException(message);

        public override string ToString()
            => $"{GetType().Name}: {FuelQuantity:F2}";
    }
}
