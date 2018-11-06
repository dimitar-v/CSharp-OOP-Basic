using System.Collections.Generic;

namespace MilitaryElite.Interfaces
{
    interface IEngineer
    {
        List<KeyValuePair<string, int>> Repairs { get; }
    }
}
