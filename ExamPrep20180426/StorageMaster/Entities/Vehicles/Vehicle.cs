using StorageMaster.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorageMaster.Entities.Vehicles
{
    public abstract class Vehicle
    {
        private List<Product> trunk;

        protected Vehicle(int capacity)
        {
            Capacity = capacity;
            trunk = new List<Product>();
        }

        public int Capacity { get; private set; }

        public IReadOnlyCollection<Product> Trunk => trunk.AsReadOnly();

        public bool IsFull => Trunk.Sum(p => p.Weight) >= Capacity;

        public bool IsEmpty => !Trunk.Any(); //TODO:Check

        public void LoadProduct(Product product)
        {
            if (IsFull)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }

            trunk.Add(product);
        }

        public Product Unload()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }

            int indexOfLast = trunk.Count - 1;
            Product product = trunk[indexOfLast];
            trunk.RemoveAt(indexOfLast);

            return product;
        }
    }
}
