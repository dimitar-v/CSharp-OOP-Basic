using Birthday_Celebrations.Classes;
using Birthday_Celebrations.Interfaces;
using System;

namespace Birthday_Celebrations.Factory
{
    class BirthdateFactory
    {
        public IBirthable CreateBirthable(string type, string name, string birthdate, int age = 0, string id = "")
        {
            switch (type.ToLower())
            {
                case "citizen":
                    return new Citizen(name, age, id, birthdate);
                case "pet":
                    return new Pet(name, birthdate);
                default:
                    throw new ArgumentException("Invalid type!");
            }

        }
    }
}
