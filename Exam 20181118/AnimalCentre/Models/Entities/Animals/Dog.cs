﻿namespace AnimalCentre.Models.Entities.Animals
{
    public class Dog : Animal
    {
        public Dog(string name, int energy, int happiness, int procedureTime)
            : base(name, energy, happiness, procedureTime) { }

        public override string ToString()
           => string.Format(base.ToString(), nameof(Dog), Name, Happiness, Energy);
    }
}
