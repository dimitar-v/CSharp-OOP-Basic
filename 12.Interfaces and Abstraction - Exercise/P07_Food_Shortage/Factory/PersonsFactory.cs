using Birthday_Celebrations.Classes;
using Food_Shortage.Classes;

namespace Food_Shortage.Factory
{
    class PersonsFactory
    {
        public Person CreatePerson(string name, int age, string id, string birthdate)
            => new Citizen(name, age, id, birthdate);

        public Person CreatePerson(string name, int age, string group)
            => new Rebel(name, age, group);
    }
}
