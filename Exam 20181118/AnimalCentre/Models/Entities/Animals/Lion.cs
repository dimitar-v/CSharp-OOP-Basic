namespace AnimalCentre.Models.Entities.Animals
{
    public class Lion : Animal
    {
        public Lion(string name, int energy, int happiness, int procedureTime)
            : base(name, energy, happiness, procedureTime) { }

        public override string ToString()
           => string.Format(base.ToString(), nameof(Lion), Name, Happiness, Energy);
    }
}
