namespace AnimalCentre.Models.Entities.Animals
{
    public class Dog : Animal
    {
        public Dog(string name, int happiness, int energy, int procedureTime)
            : base(name, happiness, energy, procedureTime) { }

        public override string ToString()
           => string.Format(base.ToString(), nameof(Dog), Name, Happiness, Energy);
    }
}
