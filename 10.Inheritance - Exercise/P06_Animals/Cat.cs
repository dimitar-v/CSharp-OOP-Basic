namespace P06_Animals
{
    class Cat : Animals
    {
        public Cat(string name, int age, string gender)
            : base(name, age, gender)
        { }

        public override string ProduceSound()
            => "Meow meow";
    }
}
