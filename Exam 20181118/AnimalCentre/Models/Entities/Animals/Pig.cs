namespace AnimalCentre.Models.Entities.Animals
{
    public class Pig : Animal
    {
        public Pig(string name, int happiness, int energy, int procedureTime)
            : base(name, happiness, energy, procedureTime) { }

        public override string ToString()
           => string.Format(base.ToString(), nameof(Pig), Name, Happiness, Energy);
    }
}
