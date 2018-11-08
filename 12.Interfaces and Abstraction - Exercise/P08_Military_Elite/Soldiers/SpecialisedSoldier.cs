using MilitaryElite.Enums;
using MilitaryElite.Interfaces;
using System;

namespace MilitaryElite.Soldiers
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private string corps;

        public SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, Corps corps)
            : base(id, firstName, lastName, salary)
        {
            Corps =  corps;
        }

        public Corps Corps { get;  }

        public override string ToString()
            => base.ToString() + Environment.NewLine
            + $"Corps: {Corps}";
    }
}
