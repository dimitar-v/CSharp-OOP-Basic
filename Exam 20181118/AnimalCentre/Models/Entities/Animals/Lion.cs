namespace AnimalCentre.Models.Entities.Animals
{
    public class Lion : Animal
    {
        public Lion(string name, int happiness, int energy, int procedureTime)
            : base(name, happiness, energy, procedureTime) { }

        public override string ToString()
           => string.Format(base.ToString(), nameof(Lion), Name, Happiness, Energy);
    }
}
