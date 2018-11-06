using Food_Shortage.Classes;
using Food_Shortage.Interfaces;

namespace Birthday_Celebrations.Classes
{
    public class Citizen : Person, IBirthable, IIdentifiable
    {
        public Citizen(string name, int age, string id, string birthdate)
            : base(name, age)
        {
            Birthdate = birthdate;
            Id = id;            
        }

        public string Birthdate { get; private set; }

        public string Id { get; private set; }
    }
}
