namespace StorageMaster.Entities.Products
{
    public class HardDrive : Product
    {
        private const double Weight = 1;

        public HardDrive(double price)
            : base(price, Weight) { }
    }
}
