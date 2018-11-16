using StorageMaster.Entities.Vehicles;

namespace StorageMaster.Entities.Storage
{
    public class DistributionCenter : Storage
    {
        private const int Capacity = 2;
        private const int GarageSlots = 5;
        private static Vehicle[] Vehicles =
        {
            new Van(),
            new Van(),
            new Van()
        };

        public DistributionCenter(string name)
            : base(name, Capacity, GarageSlots, Vehicles) { }
    }
}
