using AnimalCentre.Models.Contracts;
using AnimalCentre.Models.Entities.Animals;
using System;

namespace AnimalCentre.Facturies
{
    public class AnimalsFactory
    {
        public IAnimal CreateAnimal(string animalType, string name, int happiness, int energy, int procedureTime)
        {
            switch (animalType)
            {
                case "Cat": return new Cat(name, energy, happiness, procedureTime);
                case "Dog": return new Dog(name, energy, happiness, procedureTime);
                case "Lion": return new Lion(name, energy, happiness, procedureTime);
                /*case "Pig":*/
                default: return new Pig(name, energy, happiness, procedureTime);
                //default: throw new ArgumentException(); // TODO: 
            }
        }
    }
}
