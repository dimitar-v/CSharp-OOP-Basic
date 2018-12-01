namespace AnimalCentre.Models.Entities.Animals
{
    public class Cat : Animal
    {
        public Cat(string name, int happiness, int energy, int procedureTime)
            : base(name, happiness, energy, procedureTime) { }

        public override string ToString()
           => string.Format(base.ToString(), nameof(Cat), Name, Happiness, Energy);
    }
}
