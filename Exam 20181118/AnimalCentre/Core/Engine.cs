using System;

namespace AnimalCentre.Core
{
    class Engine
    {
        private AnimalCentre animalCentre;

        public Engine()
        {
            animalCentre = new AnimalCentre();
        }

        public void Run()
        {
            string input;
            while ((input = Read()) != "End")
            {
                try
                {
                    var args = input.Split();

                    Print(RunCommand(args));
                }
                catch (InvalidOperationException ioe)
                {
                    Print("InvalidOperationException: " + ioe.Message);
                }
                catch (ArgumentException ae)
                {
                    Print("ArgumentException: " + ae.Message);
                }
            }

            Print(animalCentre.AdoptedAnimals());
        }

        private string RunCommand(string[] args)
        {
            var command = args[0];
            string type = args[1];
            string name = args[1];
            int procedureTime;
            switch (command)
            {
                //•	RegisterAnimal {type} {name} {energy} {happiness} {procedureTime}
                //•	Chip {name} {procedureTime}
                //•	Vaccinate {name} {procedureTime}
                //•	Fitness {name} {procedureTime}
                //•	Play {name} {procedureTime}
                //•	DentalCare {name} {procedureTime}
                //•	NailTrim {name} {procedureTime}
                //•	Adopt {animal name} {owner}
                //•	History {procedureType}

                case "RegisterAnimal":
                    name = args[2];
                    int energy = int.Parse(args[3]);
                    int happiness = int.Parse(args[4]);
                    procedureTime = int.Parse(args[5]);
                    return animalCentre.RegisterAnimal(type, name, energy, happiness, procedureTime);
                case "Chip":
                    procedureTime = int.Parse(args[2]);
                    return animalCentre.Chip(name, procedureTime);
                case "Vaccinate":
                    procedureTime = int.Parse(args[2]);
                    return animalCentre.Vaccinate(name, procedureTime);
                case "Fitness":
                    procedureTime = int.Parse(args[2]);
                    return animalCentre.Fitness(name, procedureTime);
                case "Play":
                    procedureTime = int.Parse(args[2]);
                    return animalCentre.Play(name, procedureTime);
                case "DentalCare":
                    procedureTime = int.Parse(args[2]);
                    return animalCentre.DentalCare(name, procedureTime);
                case "NailTrim":
                    procedureTime = int.Parse(args[2]);
                    return animalCentre.NailTrim(name, procedureTime);
                case "Adopt":
                    string owner = args[2];
                    return animalCentre.Adopt(name, owner);
                case "History":
                    return animalCentre.History(name);
                default:
                    throw new InvalidOperationException("Invalid command");
            }
        }

        private string Read()
            => Console.ReadLine();

        private void Print(string message)
        {
            //sb.AppendLine(message);
            Console.WriteLine(message);
        }

    }
}
