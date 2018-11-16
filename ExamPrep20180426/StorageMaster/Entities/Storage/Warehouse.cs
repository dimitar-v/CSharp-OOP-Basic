using StorageMaster.Entities.Vehicles;

namespace StorageMaster.Entities.Storage
{
    public class Warehouse : Storage
    {
        private const int Capacity = 10;
        private const int GarageSlots = 10;
        private static Vehicle[] Vehicles =
        {
            new Semi(),
            new Semi(),
            new Semi()
        };

        public Warehouse(string name)
            : base(name, Capacity, GarageSlots, Vehicles) { }
    }
}
