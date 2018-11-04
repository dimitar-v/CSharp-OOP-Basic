using Farm.Factories;
using System;
using System.Collections.Generic;

namespace Farm.Core
{
    public class Engine
    {
        private AnimalFactory animalFactory;
        private List<Animal> animals;

        public Engine()
        {
            animalFactory = new AnimalFactory();
            animals = new List<Animal>();
        }

        public void Run()
        {

            string command;

            while ((command = Console.ReadLine()?.ToLower()) != "beast!")
            {
                try
                {
                    var info = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    Animal animal = animalFactory.CreateAnimal(command, info[0], int.Parse(info[1]), info[2]);
                    animals.Add(animal);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            Print();
        }

        private void Print()
        {
            animals.ForEach(a => Console.WriteLine(a));
        }
    }
}
