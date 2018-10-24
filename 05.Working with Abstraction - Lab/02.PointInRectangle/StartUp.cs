using System;
using System.Linq;

namespace PointInRectangle
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = GetRectangle();

            var numOfPoints = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfPoints; i++)
            {
                Console.WriteLine(rectangle.Contains(GetPoint()));
            }
        }

        private static Rectangle GetRectangle()
        {
            var rectangleInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            return new Rectangle(
                new Point(rectangleInfo[0], rectangleInfo[1]),
                new Point(rectangleInfo[2], rectangleInfo[3]));
        }

        private static Point GetPoint()
        {
            var pointInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            return new Point(pointInfo[0], pointInfo[1]);
        }
    }
}
