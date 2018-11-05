using System;

namespace Cars
{
    public class Car : ICar
    {
        public Car(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public string Model { get; private set; }

        public string Color { get; private set; }

        public string Start()
            => "Engine start";

        public string Stop()
            => "Breaaak!";

        public override string ToString()
            => $"{Color} {this.GetType().Name} {Model}{Environment.NewLine}" +
               $"{this.Start()}{Environment.NewLine}" +
               $"{this.Stop()}";
    }
}
