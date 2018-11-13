using System;

namespace Vehicles
{
    class Truck : Vehicle
    {
        private const double AIR_CONDITION_CONSUMPTION = 1.6;
        private const double REFUEL_PERCENT = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption , tankCapacity)
        {
            FuelConsumption += AIR_CONDITION_CONSUMPTION;
        }

        public override void Refuel(double amount)
        {
            base.Refuel(amount);

            this.FuelQuantity -= amount * (1 - REFUEL_PERCENT);
        }
           
    }
}
