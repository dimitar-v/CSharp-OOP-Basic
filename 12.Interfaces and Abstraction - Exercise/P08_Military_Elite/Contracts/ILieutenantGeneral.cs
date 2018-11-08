using System.Collections.Generic;

namespace MilitaryElite.Interfaces
{
    interface ILieutenantGeneral : IPrivate
    {
        IReadOnlyCollection<IPrivate> Privates { get; }

        void AddPrivates(IPrivate privateSoldier);
    }
}
