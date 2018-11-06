using System.Collections.Generic;

namespace MilitaryElite.Interfaces
{
    interface ICommando
    {
        Dictionary<string, string> Missions { get; }

        void CompleteMission(string missionCodeName);
    }
}
