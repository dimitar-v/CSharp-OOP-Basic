using Birthday_Celebrations.Interfaces;

namespace Birthday_Celebrations.Classes
{
    public class Citizen : Control, IBirthable
    {
        public Citizen(string name, int age, string id)
            : base(id)
        {
            Name = name;
            Age = age;
        }

        public Citizen(string name, int age, string id, string birthdate)
            : base(id)
        {
            Name = name;
            Age = age;
            Birthdate = birthdate;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Birthdate { get; private set; }
    }
}
