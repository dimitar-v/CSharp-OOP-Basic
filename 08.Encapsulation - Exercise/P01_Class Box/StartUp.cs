using System;

namespace Box
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var box = new Box(length, width, height);

            Console.WriteLine($"Surface Area - {box.GetSurfaceArea:F2}\n" +
                              $"Lateral Surface Area - {box.GetLateralSurfaceArea:F2}\n" +
                              $"Volume - {box.GetVolume:F2}");
        }
    }
}
