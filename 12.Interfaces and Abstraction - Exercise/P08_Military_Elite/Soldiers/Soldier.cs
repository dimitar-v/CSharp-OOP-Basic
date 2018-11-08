using MilitaryElite.Interfaces;

namespace MilitaryElite.Soldiers
{
    public abstract class Soldier : ISoldier
    {
        public Soldier(string id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        // TODO: Add validation

        public string Id { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public override string ToString()
            => $"Name: {FirstName} {LastName} Id: {Id}";
    }
}
