using System;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width
        {
            get => width;
            private set
            {
                //IsValid(value);
                width = value;
            }
        }
        public int Height
        {
            get => height;
            private set
            {
                //IsValid(value);
                height = value;
            }
        }

        private void IsValid(int value)
        {
            if (value < 2)
            {
                throw new ArgumentException("Value must be least 2");
            }
        }

        public void Draw()
        {
            Console.WriteLine(DrawLine('*', '*'));
            for (int i = 0; i < height - 2; i++)
            {
                Console.WriteLine(DrawLine('*', ' '));
            }
            Console.WriteLine(DrawLine('*', '*'));
        }

        private string DrawLine(char startEnd, char middle)
            => $"{startEnd}{new String(middle, width - 2)}{startEnd}";
    }
}
