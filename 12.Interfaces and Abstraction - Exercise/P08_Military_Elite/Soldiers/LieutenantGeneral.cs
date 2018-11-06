using MilitaryElite.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Soldiers
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName, salary)
        {
            Soldiers = new List<string>();
        }

        public List<string> Soldiers { get; private set; }

        public void AddPrivate(string privateToString)
        {
            Soldiers.Add(privateToString);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Privates:");
            foreach (var soldier in Soldiers)
            {
                sb.AppendLine($"  {soldier}");
            }
            return sb.ToString().Trim();
        }
    }
}
