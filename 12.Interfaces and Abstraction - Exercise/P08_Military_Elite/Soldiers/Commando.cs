using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Soldiers
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(string id, string firstName, string lastName, decimal salary, string corps) 
            : base(id, firstName, lastName, salary, corps)
        {
            Missions = new Dictionary<string, string>();
        }

        public Dictionary<string, string> Missions { get; private set; }

        public void AddMission( string codeName, string state)
        {
            if (state != "inProgress" && state != "Finished")
            {
                throw new ArgumentException("Invalid mission state");
            }

            if (!Missions.ContainsKey(codeName))
            {
                Missions[codeName] = state;
            }
        }

        public void CompleteMission(string codeName)
        {
            if (Missions.ContainsKey(codeName))
            {
                Missions[codeName] = "Finished";
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Missions:");
            foreach (var kvp in Missions)
            {
                sb.AppendLine($"  Code Name: {kvp.Key} State: {kvp.Value}");
            }
            return sb.ToString().Trim();
        }
    }
}
