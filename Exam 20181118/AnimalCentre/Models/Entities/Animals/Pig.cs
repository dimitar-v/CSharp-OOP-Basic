﻿namespace AnimalCentre.Models.Entities.Animals
{
    public class Pig : Animal
    {
        public Pig(string name, int energy, int happiness, int procedureTime)
            : base(name, energy, happiness, procedureTime) { }

        public override string ToString()
           => string.Format(base.ToString(), nameof(Pig), Name, Happiness, Energy);
    }
}
