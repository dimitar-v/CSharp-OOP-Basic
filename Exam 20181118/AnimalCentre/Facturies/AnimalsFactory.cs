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
                case "Cat": return new Cat(name, happiness, energy, procedureTime);
                case "Dog": return new Dog(name, happiness, energy, procedureTime);
                case "Lion": return new Lion(name, happiness, energy, procedureTime);
                /*case "Pig":*/
                default: return new Pig(name, happiness, energy, procedureTime);
                //default: throw new ArgumentException(); // TODO: 
            }
        }
    }
}
