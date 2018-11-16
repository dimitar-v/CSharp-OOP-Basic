using StorageMaster.Entities.Vehicles;

namespace StorageMaster.Entities.Storage
{
    public class AutomatedWarehouse : Storage
    {
        private const int Capacity = 1;
        private const int GarageSlots = 2;
        private static Vehicle[] Vehicles =
        {
            new Truck()
        };

        public AutomatedWarehouse(string name)
            : base(name, Capacity, GarageSlots, Vehicles) { }
    }
}
