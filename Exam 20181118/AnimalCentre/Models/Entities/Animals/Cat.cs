namespace AnimalCentre.Models.Entities.Animals
{
    public class Cat : Animal
    {
        public Cat(string name, int energy, int happiness, int procedureTime)
            : base(name, energy, happiness, procedureTime) { }

        public override string ToString()
           => string.Format(base.ToString(), nameof(Cat), Name, Happiness, Energy);
    }
}
