using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var engines = new List<Engine>();
            var cars = new List<Car>();

            var num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                var engineDetails = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var model = engineDetails[0];
                var power = int.Parse(engineDetails[1]);
                var engine = new Engine(model, power);

                switch (engineDetails.Length)
                {
                    case 3:
                        if (int.TryParse(engineDetails[2], out _))
                            engine.Displacement = engineDetails[2];
                        else
                            engine.Efficiency = engineDetails[2];
                        break;
                    case 4:
                        engine.Displacement = engineDetails[2];
                        engine.Efficiency = engineDetails[3];
                        break;
                }

                engines.Add(engine);
            }

            num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                var carDetails = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var model = carDetails[0];
                var engine = carDetails[1];
                                
                var car = new Car(model, engines.Where(e => e.Model == engine).FirstOrDefault());

                switch (carDetails.Length)
                {
                    case 3:
                        if (int.TryParse(carDetails[2], out _))
                        {
                            car.Weight = carDetails[2];
                        }
                        else
                        {
                            car.Color = carDetails[2];
                        }
                        break;
                    case 4:
                        car.Weight = carDetails[2];
                        car.Color = carDetails[3];
                        break;
                }
                cars.Add(car);
            }

            cars.ForEach(Console.WriteLine);
        }
    }
}
