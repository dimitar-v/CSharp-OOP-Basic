using System;
using System.Linq;
using System.Text;

namespace StorageMaster.Core
{
    class Engine
    {
        StorageMaster storageMaster;
        StringBuilder sb;

        public Engine()
        {
            storageMaster = new StorageMaster();
            sb = new StringBuilder();
        }

        public void Run()
        {
            sb.AppendLine("=====================");
            string input;
            while ((input = Read()) != "END")
            {
                try
                {
                    var args = input.Split();

                    Print(RunCommand(args));
                }
                catch (InvalidOperationException ioe)
                {
                    Print("Error: " + ioe.Message);                    
                }
            }

            Print(storageMaster.GetSummary());

            //Console.WriteLine(sb.ToString()); //Remove the comment from the front to get the Output collected
        }

        private string RunCommand(string[] args)
        {
            var command = args[0];
            string type = args[1];
            string name = args[1];
            int garageSlot;

            switch (command)
            {
                case "AddProduct":
                    double price = double.Parse(args[2]);
                    return storageMaster.AddProduct(type, price);
                case "RegisterStorage":
                    name = args[2];
                    return storageMaster.RegisterStorage(type, name);
                case "SelectVehicle":
                    garageSlot = int.Parse(args[2]);
                    return storageMaster.SelectVehicle(name, garageSlot);
                case "LoadVehicle":
                    return storageMaster.LoadVehicle(args.Skip(1));
                case "SendVehicleTo":
                    garageSlot = int.Parse(args[2]);
                    string destination = args[3];
                    return storageMaster.SendVehicleTo(name, garageSlot, destination);
                case "UnloadVehicle":
                    garageSlot = int.Parse(args[2]);
                    return storageMaster.UnloadVehicle(name, garageSlot);
                case "GetStorageStatus":
                    return storageMaster.GetStorageStatus(name);
                default:
                    throw new InvalidOperationException("Invalid command");
            }
        }

        private string Read()
            => Console.ReadLine();

        private void Print(string message)
        {
            sb.AppendLine(message);
            Console.WriteLine(message);
        }

    }
}
