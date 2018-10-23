using System;
using System.Collections.Generic;
using System.Linq;

namespace RectangleIntersection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var rectangles = new Dictionary<string, Rectangle>();
            var nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            for (int i = 0; i < nums[0]; i++)
            {
                var rectangle = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var id = rectangle[0];
                var width = double.Parse(rectangle[1]);
                var height = double.Parse(rectangle[2]);
                var x = double.Parse(rectangle[3]);
                var y = double.Parse(rectangle[4]);

                if (!rectangles.ContainsKey(id))
                {
                    rectangles[id] = new Rectangle(width, height, x, y);
                }
            }

            for (int i = 0; i < nums[1]; i++)
            {
                var ids = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var r1 = ids[0];
                var r2 = ids[1];

                Console.WriteLine(rectangles[r1].IsIntersect(rectangles[r2]));
            }
        }
    }
}
