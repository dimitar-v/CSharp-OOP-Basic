using System;

namespace Shapes
{
    class Circle : Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; private set; }

        public override double CalculateArea()
            => Math.PI * Math.Pow(Radius, 2);

        public override double CalculatePerimeter()
            => Math.PI * 2 * Radius;

        public override string Draw()
            => base.Draw() + " " + this.GetType().Name;
    }
}
