using AnimalCentre.Facturies;
using AnimalCentre.Models.Contracts;
using AnimalCentre.Models.Entities;
using AnimalCentre.Models.Entities.Procedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalCentre.Core
{
    class AnimalCentre
    {
        private AnimalsFactory animalFactory;
        private ProcedurFactory procedurFactory;

        private Dictionary<string, List<string>> adopted;
        private Dictionary<string, Procedure> procedures;

        private Hotel hotel;

        public AnimalCentre()
        {
            animalFactory = new AnimalsFactory();
            procedurFactory = new ProcedurFactory();
            adopted = new Dictionary<string, List<string>>();
            procedures = new Dictionary<string, Procedure>();
            hotel = new Hotel();
        }



        public string RegisterAnimal(string type, string name, int energy, int happiness, int procedureTime)
        {
            IAnimal animal = animalFactory.CreateAnimal(type, name, happiness, energy, procedureTime);

            hotel.Accommodate(animal);

            return $"Animal {name} registered successfully";
        }

        public string Chip(string name, int procedureTime)
        {
            MakeProcedure(nameof(Chip), name, procedureTime);

            return $"{name} had chip procedure";
        }

        public string Vaccinate(string name, int procedureTime)
        {
            MakeProcedure(nameof(Vaccinate), name, procedureTime);

            return $"{name} had vaccination procedure";
        }

        public string Fitness(string name, int procedureTime)
        {
            MakeProcedure(nameof(Fitness), name, procedureTime);
            
            return $"{name} had fitness procedure";
        }

        public string Play(string name, int procedureTime)
        {
            MakeProcedure(nameof(Play), name, procedureTime);

            return $"{name} was playing for {procedureTime} hours";
        }

        public string DentalCare(string name, int procedureTime)
        {
            MakeProcedure(nameof(DentalCare), name, procedureTime);

            return $"{name} had dental care procedure";
        }

        public string NailTrim(string name, int procedureTime)
        {
            MakeProcedure(nameof(NailTrim), name, procedureTime);

            return $"{name} had nail trim procedure";
        }

        public string Adopt(string animalName, string owner)
        {
            IAnimal animal = hotel.GetAnimal(animalName);
            hotel.Adopt(animalName, owner);

            if (!adopted.ContainsKey(owner))
            {
                adopted[owner] = new List<string>();
            }

            adopted[owner].Add(animal.Name);

            string result;

            if (animal.IsChipped)
            {
                result = $"{owner} adopted animal with chip";
            }
            else
            {
                result = $"{owner} adopted animal without chip";
            }

            return result;
        }

        public string History(string type)
        {
            return procedures[type].History();
        }

        public string AdoptedAnimals()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var kvp in adopted.OrderBy(kvp => kvp.Key))
            {
                sb.AppendLine($"--Owner: {kvp.Key}{Environment.NewLine}    - Adopted animals: {string.Join(" ", kvp.Value)}");
            }

            return sb.ToString().Trim();
        }

        private void MakeProcedure(string procedureName, string name, int procedureTime)
        {
            if (!procedures.ContainsKey(procedureName))
            {
                procedures[procedureName] = procedurFactory.CreateProcedure(procedureName);
            }

            IAnimal animal = hotel.GetAnimal(name);
            procedures[procedureName].DoService(animal, procedureTime);
        }

    }
}
