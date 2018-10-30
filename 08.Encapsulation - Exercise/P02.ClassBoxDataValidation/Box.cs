using System;

namespace Box
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public double Length
        {
            set
            {
                if (!IsValid(value))
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                length = value;
            }
        }

        public double Width
        {
            set
            {
                if (!IsValid(value))
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                width = value;
            }
        }

        public double Height
        {
            set
            {
                if (!IsValid(value))
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                height = value;
            }
        }


        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double GetVolume => length * width * height;

        public double GetSurfaceArea => 2 * length * width + this.GetLateralSurfaceArea;

        public double GetLateralSurfaceArea => 2 * length * height + 2 * width * height;

        private bool IsValid(double lenght) => lenght > 0;
    }
}
