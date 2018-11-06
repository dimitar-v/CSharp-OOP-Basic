using MilitaryElite.Interfaces;

namespace MilitaryElite.Soldiers
{
    public class Private : Soldier, IPrivate
    {
        public Private(string id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName)
        {
            Salary = salary;
        }

        public decimal Salary { get; private set; }

        public override string ToString()
            => base.ToString() + $" Salary: {Salary:F2}";
    }
}
