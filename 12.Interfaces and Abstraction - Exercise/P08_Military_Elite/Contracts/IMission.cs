using MilitaryElite.Enums;

namespace MilitaryElite.Interfaces
{
    public interface IMission
    {
        string CodeName { get; }

        State State { get; }

        void ComplateMission();
    }
}