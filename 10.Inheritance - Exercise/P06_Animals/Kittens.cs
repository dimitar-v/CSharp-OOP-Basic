namespace P06_Animals
{
    class Kittens : Cat
    {
        public Kittens(string name, int age)
            : base(name, age, "Femail")
        { }

        public override string ProduceSound()
            => "Meow";
    }
}
