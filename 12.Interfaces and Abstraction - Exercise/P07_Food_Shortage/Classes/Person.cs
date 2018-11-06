using Food_Shortage.Interfaces;

namespace Food_Shortage.Classes
{
    public class Person : IBuyer
    {
        private const int INITIAL_FOOD = 0;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Food = INITIAL_FOOD;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public int Food { get; set; }

        public virtual void ByeFood()
            => Food += 10;
    }
}
