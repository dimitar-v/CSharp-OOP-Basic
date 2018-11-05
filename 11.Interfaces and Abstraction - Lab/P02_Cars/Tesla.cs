using System;

namespace Cars
{
    public class Tesla : Car, IElectricCar
    {
        public Tesla(string model, string color, int battery)
            : base(model, color)
        {
            Battery = battery;
        }

        public int Battery { get; private set; }

        public override string ToString()
            => $"{Color} {this.GetType().Name} {Model} with {Battery} Batteries{Environment.NewLine}" +
               $"{this.Start()}{Environment.NewLine}" +
               $"{this.Stop()}";
    }
}
