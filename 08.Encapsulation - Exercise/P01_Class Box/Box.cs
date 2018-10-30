namespace Box
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public double GetVolume => length * width * height;

        public double GetSurfaceArea => 2 * length * width + this.GetLateralSurfaceArea;

        public double GetLateralSurfaceArea => 2 * length * height + 2 * width * height;
    }
}
