namespace P06_Animals
{
    class Dog : Animals
    {
        public Dog(string name, int age, string gender)
            : base(name, age, gender)
        { }

        public override string ProduceSound()
            => "Woof!";
    }
}
