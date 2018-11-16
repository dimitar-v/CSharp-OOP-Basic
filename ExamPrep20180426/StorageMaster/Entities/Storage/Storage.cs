using StorageMaster.Entities.Products;
using StorageMaster.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorageMaster.Entities.Storage
{
    public abstract class Storage
    {
        private Vehicle[] garage;

        private List<Product> products;

        protected Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            Name = name;
            Capacity = capacity;
            GarageSlots = garageSlots;

            garage = new Vehicle[garageSlots];
            InitializaFillGarage(vehicles);

            products = new List<Product>();
        }

        public string Name { get; private set; }

        public int Capacity { get; private set; }

        public int GarageSlots { get; private set; }

        public bool IsFull => Products.Sum(p => p.Weight) >= Capacity;

        public IReadOnlyCollection<Vehicle> Garage => Array.AsReadOnly(garage);

        public IReadOnlyCollection<Product> Products => products.AsReadOnly();

        public Vehicle GetVehicle(int garageSlot)
        {
            if (garageSlot >= GarageSlots || garageSlot < 0)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }

            Vehicle vehicle = garage[garageSlot];

            if (vehicle == null)
            {
                throw new InvalidOperationException("No vehicle in this garage slot!");
            }

            return vehicle;
        }

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            Vehicle vehicle = GetVehicle(garageSlot);

            int deliverySloth = deliveryLocation.AcceptVehicle(vehicle);

            garage[garageSlot] = null;

            return deliverySloth;
        }
               
        public int UnloadVehicle(int garageSlot)
        {
            if (IsFull)
            {
                throw new InvalidOperationException("Storage is full!");
            }

            Vehicle vehicle = GetVehicle(garageSlot);

            int unloadedCount = 0;

            while (!IsFull && !vehicle.IsEmpty)
            {
                products.Add(vehicle.Unload());
                unloadedCount++;
            }
            
            return unloadedCount;
        }

        private int AcceptVehicle(Vehicle vehicle)
        {
            int freeSlot = Array.IndexOf(garage, null);

            if (freeSlot == -1)
            {
                throw new InvalidOperationException("No room in garage!");
            }

            garage[freeSlot] = vehicle;

            return freeSlot;
        }

        private void InitializaFillGarage(IEnumerable<Vehicle> vehicles)
        {
            int count = 0;
            foreach (var vehicle in vehicles)
            {
                garage[count++] = vehicle;
            }
        }
    }
}
