using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cars = new List<Car>();

            var num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var model = input[0];
                var engineSpeed = int.Parse(input[1]);
                var enginePower = int.Parse(input[2]);
                var cargoWeight = int.Parse(input[3]);
                var cargoType  = input[4];
                var tire1Pressure = double.Parse(input[5]);
                var tire1Age = int.Parse(input[6]);
                var tire2Pressure = double.Parse(input[7]);
                var tire2Age = int.Parse(input[8]);
                var tire3Pressure = double.Parse(input[9]);
                var tire3Age = int.Parse(input[10]);
                var tire4Pressure = double.Parse(input[11]);
                var tire4Age = int.Parse(input[12]);

                cars.Add(new Car(model, new Engine(engineSpeed, enginePower), new Cargo(cargoWeight, cargoType),
                    new Tires(tire1Age, tire1Pressure, tire2Age, tire2Pressure, tire3Age, tire3Pressure, tire4Age, tire4Pressure)));
            }
              
            if (Console.ReadLine() == "fragile")
            {
                cars.Where(c => c.Cargo.Type == "fragile" && (c.Tires.Pressure1 < 1 || c.Tires.Pressure2 < 1 ||
                c.Tires.Pressure3 < 1 || c.Tires.Pressure4 < 1))
                .ToList()
                .ForEach(c => Console.WriteLine(c.Model));
            }
            else
            {
                cars.Where(c => c.Cargo.Type == "flamable" && c.Engine.EnginePower > 250)
                    .ToList()
                    .ForEach(c => Console.WriteLine(c.Model));
            }
        }
    }
}
