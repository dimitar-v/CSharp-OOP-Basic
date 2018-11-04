namespace Farm
{
    public class Tomcat : Cat
    {
        private const string MALE = "Male";

        public Tomcat(string name, int age)
            : base(name, age, MALE)
        {   }

        public override string ProduceSound()
            => "MEOW";
    }
}
