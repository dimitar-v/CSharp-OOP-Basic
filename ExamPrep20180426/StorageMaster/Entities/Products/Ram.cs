﻿namespace StorageMaster.Entities.Products
{
    public  class Ram : Product
    {
        private const double Weight = 0.1;

        public Ram(double price)
            : base(price, Weight) { }
    }
}
