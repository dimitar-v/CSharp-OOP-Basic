using System;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var carInfo = Console.ReadLine().Split();
            var truckInfo = Console.ReadLine().Split();
            var busInfo = Console.ReadLine().Split();

            var carFuelQuantity = double.Parse(carInfo[1]);
            var carConsumption = double.Parse(carInfo[2]);
            var carTankCapacity = double.Parse(carInfo[3]);

            var truckFuelQuantity = double.Parse(truckInfo[1]);
            var truckConsumption = double.Parse(truckInfo[2]);
            var truckTankCapacity = double.Parse(truckInfo[3]);

            var busFuelQuantity = double.Parse(busInfo[1]);
            var busConsumption = double.Parse(busInfo[2]);
            var busTankCapacity = double.Parse(busInfo[3]);

            IVehicle car = new Car(carFuelQuantity, carConsumption, carTankCapacity);
            IVehicle truck = new Truck(truckFuelQuantity, truckConsumption, truckTankCapacity);
            IVehicle bus = new Bus(busFuelQuantity, busConsumption, busTankCapacity);

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                var value = double.Parse(input[2]);

                switch (input[1])
                {
                    case "Car":
                        Action(car, input[0], value);
                        break;
                    case "Truck":
                        Action(truck, input[0], value);
                        break;
                    case "Bus":
                        Action(bus, input[0], value);
                        break;
                }

            }

            Print(car.ToString());
            Print(truck.ToString());
            Print(bus.ToString());
        }

        private static void Print(string message)
            => Console.WriteLine(message);

        private static void Action(IVehicle vehicle, string action, double value)
        {
            try
            {
                switch (action)
                {
                    case "Drive":
                        Print(vehicle.Drive(value));
                        break;
                    case "Refuel":
                        vehicle.Refuel(value);
                        break;
                    case "DriveEmpty":
                        if (vehicle is Bus bus)
                        {
                            Print(bus.DriveEmpty(value));
                        }
                        break;
                }
            }
            catch (ArgumentException ae)
            {
                Print(ae.Message);
            }
        }
    }
}
