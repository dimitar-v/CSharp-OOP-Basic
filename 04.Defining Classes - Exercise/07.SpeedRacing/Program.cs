using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cars = new Dictionary<string, Car>();

            var num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var model = input[0];
                var fuelInTank = double.Parse(input[1]);
                var fuelConsumption = double.Parse(input[2]);

                if (!cars.ContainsKey(model))
                {
                    cars[model] = new Car(model, fuelInTank, fuelConsumption);
                }
            }

            string command;

            while ((command = Console.ReadLine())?.ToLower() != "end")
            {
                var commands = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (commands[0] == "Drive")
                {
                    var model = commands[1];
                    var distance = double.Parse(commands[2]);

                    if (cars.ContainsKey(model))
                    {
                        cars[model].Drive(distance);
                    }
                }
            }

            foreach (var car in cars.Values)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
