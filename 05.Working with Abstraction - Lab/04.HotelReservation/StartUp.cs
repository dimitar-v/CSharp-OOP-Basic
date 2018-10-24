using System;

namespace HotelReservation
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var calculator = new PriceCalculator(Console.ReadLine);

            Console.WriteLine($"{calculator.Calculate():F2}");
        }
    }
}
