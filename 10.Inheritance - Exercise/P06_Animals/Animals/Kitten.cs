namespace Farm
{
    public class Kitten : Cat
    {
        private const string FEMALE = "Female";

        public Kitten(string name, int age)
            : base(name, age, FEMALE)
        { }

        public override string ProduceSound()
            => "Meow";
    }
}
