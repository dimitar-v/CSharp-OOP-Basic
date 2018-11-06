namespace Border_Control
{
    public class Citizen : Control
    {
        public Citizen(string name, int age, string id)
            : base(id)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }
    }
}
