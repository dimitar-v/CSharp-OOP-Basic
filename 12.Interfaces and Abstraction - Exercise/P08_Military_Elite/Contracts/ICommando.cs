using System.Collections.Generic;

namespace MilitaryElite.Interfaces
{
    interface ICommando : ISpecialisedSoldier
    {
        IReadOnlyCollection<IMission> Missions { get; }

        void AddMission(IMission mission);
    }
}
