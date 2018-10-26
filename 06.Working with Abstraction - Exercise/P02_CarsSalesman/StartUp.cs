using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_CarsSalesman
{
    class CarSalesman
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Engine> engines = new List<Engine>();

            int engineCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < engineCount; i++)
            {
                engines.Add(GetEngine(Console.ReadLine));
            }

            int carCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < carCount; i++)
            {
                cars.Add(GetCar(Console.ReadLine, engines));
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }

        private static Car GetCar(Func<string> readLine, List<Engine> engines)
        {
            string[] parameters = readLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string model = parameters[0];
            Engine engine = engines.FirstOrDefault(x => x.Model == parameters[1]);

            var car = new Car(model, engine);

            if (parameters.Length == 3 && int.TryParse(parameters[2], out int weight))
            {
                car.Weight = weight;
            }
            else if (parameters.Length == 3)
            {
                car.Color = parameters[2];
            }
            else if (parameters.Length == 4)
            {
                car.Weight = int.Parse(parameters[2]);
                car.Color = parameters[3];
            }

            return car;
        }

        private static Engine GetEngine(Func<string> readLine)
        {
            string[] parameters = readLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string model = parameters[0];
            int power = int.Parse(parameters[1]);

            var engine = new Engine(model, power);

            if (parameters.Length == 3 && int.TryParse(parameters[2], out int displacement))
            {
                engine.Displacement = displacement;
            }
            else if (parameters.Length == 3)
            {
                engine.Efficiency = parameters[2];
            }
            else if (parameters.Length == 4)
            {
                engine.Displacement = int.Parse(parameters[2]);
                engine.Efficiency = parameters[3];
            }

            return engine;
        }
    }
}
