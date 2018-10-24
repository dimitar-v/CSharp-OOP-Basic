using System;

namespace RhombusOfStars
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var rhombusSize = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rhombusSize; i++)
            {
                PrintRow(rhombusSize, i);
            }

            for (int i = rhombusSize - 1; i > 0; i--)
            {
                PrintRow(rhombusSize, i);
            }
        }

        private static void PrintRow(int rhombusSize, int stars)
        {
            for (int i = 1; i <= rhombusSize - stars; i++)
            {
                Console.Write(" ");
            }

            for (int i = 1; i < stars; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine("*");
        }
    }
}
