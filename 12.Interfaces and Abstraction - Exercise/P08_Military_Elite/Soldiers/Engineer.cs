using MilitaryElite.Enums;
using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Soldiers
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private List<IRepair> repairs;

        public Engineer(string id, string firstName, string lastName, decimal salary, Corps corps)
            : base(id, firstName, lastName, salary, corps)
        {
            repairs = new List<IRepair>();
        }

        public IReadOnlyCollection<IRepair> Repairs => repairs.AsReadOnly();

        public void AddRepair(IRepair repair)
            => repairs.Add(repair);

        public override string ToString()
            => base.ToString() + Environment.NewLine
            + "Repairs:" + (Repairs.Count != 0 ? Environment.NewLine + "  " : "")
            + string.Join(Environment.NewLine + "  ", Repairs);


        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine(base.ToString());
        //    sb.AppendLine("Repairs:");
        //    foreach (var repair in Repairs)
        //    {
        //        sb.AppendLine($"  Part Name: {repair.PartName} Hours Worked: {repair.HoursWorked}");
        //    }
        //    return sb.ToString().Trim();
        //}
    }
}
