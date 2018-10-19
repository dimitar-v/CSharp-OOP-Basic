using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKm;
        private double traveledDistance;

        public Car(string model, double fuelInTank, double consumption)
        {
            this.Model = model;
            this.FuelAmount = fuelInTank;
            this.FuelConsumptionPerKm = consumption;
            this.TraveledDistance = 0;
        }

        public void Drive(double km)
        {
            var totalConsum = this.FuelConsumptionPerKm * km;
            if (totalConsum > this.FuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.TraveledDistance += km;
                this.FuelAmount -= totalConsum;
            }
            
        }

        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:F2} {this.TraveledDistance}";
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public double FuelAmount
        {
            get { return this.fuelAmount; }
            set { this.fuelAmount = value; }
        }

        public double FuelConsumptionPerKm
        {
            get { return this.fuelConsumptionPerKm; }
            set { this.fuelConsumptionPerKm = value; }
        }

        public double TraveledDistance
        {
            get { return this.traveledDistance; }
            set { this.traveledDistance = value; }
        }
    }
}
