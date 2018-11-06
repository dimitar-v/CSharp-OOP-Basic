namespace Food_Shortage.Classes
{
    public class Rebel : Person
    {
        public Rebel(string name, int age, string group)
            : base(name, age)
        {
            Group = group;
        }

        public string Group { get; private set; }

        public override void ByeFood()
            => base.Food += 5;
    }
}
