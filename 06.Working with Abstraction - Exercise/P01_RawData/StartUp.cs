using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_RawData
{
    class RawData
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] parameters = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int engineSpeed = int.Parse(parameters[1]);
                int enginePower = int.Parse(parameters[2]);

                int cargoWeight = int.Parse(parameters[3]);
                string cargoType = parameters[4];

                string model = parameters[0];
                var engine = new Engine(engineSpeed, enginePower);
                var cargo = new Cargo(cargoWeight, cargoType);
                var tires = new List<Tire>();

                for (int j = 0; j < 8; j += 2)
                {
                    double pressure = double.Parse(parameters[5 + j]);
                    int age = int.Parse(parameters[6 + j]);

                    tires.Add(new Tire(pressure, age));
                }
                
                cars.Add(new Car(model, engine, cargo, tires));
            }

            List<string> carList;
            if (Console.ReadLine() == "fragile")
            {
                carList = cars
                    .Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(y => y.Pressure < 1))
                    .Select(x => x.Model)
                    .ToList();
            }
            else
            {
                carList = cars
                    .Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250)
                    .Select(x => x.Model)
                    .ToList();
            }

            Console.WriteLine(string.Join(Environment.NewLine, carList));
        }
    }
}
