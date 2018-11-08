using MilitaryElite.Enums;

namespace MilitaryElite.Interfaces
{
    public interface ISpecialisedSoldier : IPrivate
    {
        Corps Corps { get; }
    }
}
