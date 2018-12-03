using AnimalCentre.Models.Contracts;
using System;

namespace AnimalCentre.Models.Entities.Animals
{
    public abstract class Animal : IAnimal
    {
        private int happiness;
        private int energy;

        protected Animal(string name, int energy , int happiness, int procedureTime)
        {
            Name = name;
            Happiness = happiness;
            Energy = energy;
            ProcedureTime = procedureTime;
        }

        public string Name { get; private set; }

        public int Happiness
        {
            get => happiness;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Invalid happiness");
                }

                happiness = value;
            }
        }

        public int Energy
        {
            get => energy;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Invalid energy");
                }

                energy = value;
            }
        }

        public int ProcedureTime { get; set; }

        public string Owner { get;  set; } = "Centre";

        public bool IsAdopt { get; set; } = false;

        public bool IsChipped { get; set; } = false;

        public bool IsVaccinated { get; set; } = false;

        public override string ToString()
            => "    Animal type: {0} - {1} - Happiness: {2} - Energy: {3}";
    }
}
