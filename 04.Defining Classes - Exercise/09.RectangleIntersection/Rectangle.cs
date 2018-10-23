using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleIntersection
{
    public class Rectangle
    {
        private double width;
        private double height;
        private double x;
        private double y;

        public Rectangle(double width, double height, double x, double y)
        {
            this.Width = width;
            this.Height = height;
            this.X = x;
            this.Y = y;
        }

        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public string IsIntersect(Rectangle rectangle) =>
            this.X <= rectangle.X + rectangle.Width && this.X + this.Width >= rectangle.X
            && this.Y <= rectangle.Y + rectangle.Height && this.Y + this.Height >= rectangle.Y
            ? "true" : "false";
    }
}
