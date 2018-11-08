using MilitaryElite.Enums;
using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Soldiers
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        private List<IMission> missions;

        public Commando(string id, string firstName, string lastName, decimal salary, Corps corps) 
            : base(id, firstName, lastName, salary, corps)
        {
            missions = new List<IMission>();
        }

        public IReadOnlyCollection<IMission> Missions { get => missions.AsReadOnly();}

        public void AddMission(IMission mission)
            => missions.Add(mission);

        public override string ToString()
            => base.ToString() + Environment.NewLine
            + "Missions:" + (Missions.Count != 0 ? Environment.NewLine + "  " : "")
            + string.Join(Environment.NewLine + "  ", Missions);

        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine(base.ToString());
        //    sb.AppendLine("Missions:");
        //    foreach (var mission in Missions)
        //    {
        //        sb.AppendLine($"  Code Name: {mission.CodeName} State: {mission.State}");
        //    }
        //    return sb.ToString().Trim();
        //}
    }
}
