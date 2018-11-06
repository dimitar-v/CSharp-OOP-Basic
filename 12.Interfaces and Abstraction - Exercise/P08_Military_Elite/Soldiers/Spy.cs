using MilitaryElite.Interfaces;
using System;

namespace MilitaryElite.Soldiers
{
    public class Spy : Soldier, ISpy
    {
        public Spy(string id, string firstName, string lastName, int codeNumber)
            : base(id, firstName, lastName)
        {
            CodeNunber = codeNumber;
        }

        public int CodeNunber { get; private set; }

        public override string ToString()
            => base.ToString() + Environment.NewLine
             + $"Code Number: {CodeNunber}";
    }
}
