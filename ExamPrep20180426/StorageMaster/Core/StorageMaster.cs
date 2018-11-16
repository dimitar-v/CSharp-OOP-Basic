using StorageMaster.Entities.Products;
using StorageMaster.Entities.Storage;
using StorageMaster.Entities.Vehicles;
using StorageMaster.Factories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorageMaster.Core
{
    public class StorageMaster
    {
        private ProductFactory productFactory;

        private StorageFactory storageFactory;

        private Vehicle currentVehicle;

        private Dictionary<string, Stack<Product>> productsPool;

        private Dictionary<string, Storage> storages;

        public StorageMaster()
        {
            productFactory = new ProductFactory();

            storageFactory = new StorageFactory();

            productsPool = new Dictionary<string, Stack<Product>>();

            storages = new Dictionary<string, Storage>();
        }

        public string AddProduct(string type, double price)
        {
            Product product = productFactory.CreateProduct(type, price);

            if (!productsPool.ContainsKey(type))
            {
                productsPool[type] = new Stack<Product>();
            }

            productsPool[type].Push(product);

            return $"Added {type} to pool";
        }

        public string RegisterStorage(string type, string name)
        {
            Storage storage = storageFactory.CreateStorage(type, name);

            storages[name] = storage;

            return $"Registered {storage.Name}";
        }

        public string SelectVehicle(string storageName, int garageSlot)
        {
            currentVehicle = storages[storageName].GetVehicle(garageSlot);

            return $"Selected {currentVehicle.GetType().Name}";
        }

        public string LoadVehicle(IEnumerable<string> productNames)
        {
            int loadedProductsCount = 0;
            foreach (var name in productNames)
            {
                if (currentVehicle.IsFull)
                {
                    break;
                }

                if (!productsPool.ContainsKey(name)
                    || productsPool[name].Count == 0)
                {
                    throw new InvalidOperationException($"{name} is out of stock!");
                }

                currentVehicle.LoadProduct(productsPool[name].Pop());

                loadedProductsCount++;
            }

            return $"Loaded {loadedProductsCount}/{productNames.Count()} products into {currentVehicle.GetType().Name}";
        }

        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            if (!storages.ContainsKey(sourceName))
            {
                throw new InvalidOperationException("Invalid source storage!");
            }

            if (!storages.ContainsKey(destinationName))
            {
                throw new InvalidOperationException("Invalid destination storage!");
            }

            Storage destinationStorage = storages[destinationName];

            int slotNum = storages[sourceName].SendVehicleTo(sourceGarageSlot, destinationStorage);

            Vehicle vehicle = destinationStorage.GetVehicle(slotNum);

            return $"Sent {vehicle.GetType().Name} to {destinationName} (slot {slotNum})";
        }

        public string UnloadVehicle(string storageName, int garageSlot)
        {
            Storage storage = storages[storageName];

            int productsInVehicle = storage.GetVehicle(garageSlot).Trunk.Count;

            int unloadedProductsCount = storage.UnloadVehicle(garageSlot);

            return $"Unloaded {unloadedProductsCount}/{productsInVehicle} products at {storageName}";
        }

        public string GetStorageStatus(string storageName)
        {
            Storage storage = storages[storageName];

            var productsSum = storage.Products.Sum(p => p.Weight);

            var nameAndCount = storage.Products
                .GroupBy(p => p.GetType().Name)
                .OrderByDescending(g => g.Count())
                .ThenBy(g => g.GetType().Name)
                //.ToDictionary(kvp => kvp.Key, kvp => kvp.Count())
                .Select(kvp => $"{kvp.Key} ({kvp.Count()})")
                .ToArray();

            var garage = storage.Garage
                .Select(v => v == null ? "empty" : v.GetType().Name)
                .ToArray();

            return $"Stock ({productsSum}/{storage.Capacity}): [{string.Join(", ", nameAndCount)}]" +
                $"{Environment.NewLine}Garage: [{string.Join("|", garage)}]";
        }

        public string GetSummary()
        {
            var storageByPrice = storages
                .ToDictionary(s => s.Key, s => s.Value.Products.Sum(p => p.Price))
                .OrderByDescending(kvp => kvp.Value)
                .Select(kvp => $"{kvp.Key}:{Environment.NewLine}Storage worth: ${kvp.Value:F2}")
                .ToArray();

            //var storageByPrice = storages
            //    .Select(s => s.Value)
            //    .OrderByDescending(s => s.Products.Sum(p => p.Price))
            //    .Select(s => $"{s.Name}:{Environment.NewLine}Storage worth: ${s.Products.Sum(p => p.Price):F2}")
            //    .ToArray();

            return string.Join(Environment.NewLine, storageByPrice);
        }

    }
}
