using AnimalCentre.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AnimalCentre.Models.Entities
{
    public class Hotel : IHotel
    {
        private const int capacity = 10;

        private Dictionary<string, IAnimal> animals;

        public Hotel()
        {
            animals = new Dictionary<string, IAnimal>();
        }

        public int Capacity { get; private set; } = capacity;

        public IReadOnlyDictionary<string, IAnimal> Animals
            => new ReadOnlyDictionary<string, IAnimal>(animals);

        public void Accommodate(IAnimal animal)
        {
            if (animals.Count == Capacity)
            {
                throw new InvalidOperationException("Not enough capacity");
            }

            if (animals.ContainsKey(animal.Name))
            {
                throw new ArgumentException($"Animal {animal.Name} already exist");
            }

            animals[animal.Name] = animal;
        }

        public void Adopt(string animalName, string owner)
        {
            if (!animals.ContainsKey(animalName))
            {
                throw new ArgumentException($"Animal {animalName} does not exist");
            }

            IAnimal animal = animals[animalName];
            animal.Owner = owner;
            animal.IsAdopt = true;
            animals.Remove(animalName);
        }

        private void ContainsAnimal(string name)
        {
            if (!animals.ContainsKey(name))
            {
                throw new ArgumentException($"Animal {name} does not exist");
            }
        }

        public IAnimal GetAnimal(string name)
        {
            ContainsAnimal(name);
            return animals[name];
        }
    }
}
