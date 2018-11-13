using System;
using System.Collections.Generic;
using WildFarm.Contracts;
using WildFarm.Factory;

namespace WildFarm.Core
{
    public class Engine
    {
        private FoodFactory foodFactory;
        private AnimalFactory animalFactory;
        private List<IAnimal> animals;

        public Engine()
        {
            foodFactory = new FoodFactory();
            animalFactory = new AnimalFactory();
            animals = new List<IAnimal>();
        }

        public void Run()
        {
            string input;
            while ((input = Read()) != "End")
            {
                try
                {
                    IAnimal animal = animalFactory.CreateAnimal(input.Split());

                    IFood food = foodFactory.CreateFood(Read().Split());

                    animals.Add(animal);
                    Print(animal.AskFood());

                    animal.Eat(food);
                }
                catch (ArgumentException ae)
                {
                    Print(ae.Message);
                }

            }

            animals.ForEach(a => Print(a.ToString()));
        }

        private string Read()
            => Console.ReadLine();

        private void Print(string message)
            => Console.WriteLine(message);
    }
}
