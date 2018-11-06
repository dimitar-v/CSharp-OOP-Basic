using MilitaryElite.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Soldiers
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            Repairs = new List<KeyValuePair<string, int>>();
        }

        public List<KeyValuePair<string, int>> Repairs { get; private set; }

        public void AddRepairs(string partName, int hours)
        {
            Repairs.Add(new KeyValuePair<string, int>(partName, hours));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Repairs:");
            foreach (var kvp in Repairs)
            {
                sb.AppendLine($"  Part Name: {kvp.Key} Hours Worked: {kvp.Value}");
            }
            return sb.ToString().Trim();
        }
    }
}
