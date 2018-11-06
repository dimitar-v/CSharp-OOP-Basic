using MilitaryElite.Soldiers;
using System;

namespace MilitaryElite.Factories
{
    class SoldierFactory
    {
        public Soldier GetSoldier(string id, string firstName, string lastName, decimal salary)
            => new Private(id, firstName, lastName, salary);

        public Soldier GetSoldier(string id, string firstName, string lastName, int codeNumber)
            => new Spy(id, firstName, lastName, codeNumber);

        public Soldier GetSoldier(string id, string firstName, string lastName, decimal salary,
                                  string[] privates)
        {
            LieutenantGeneral soldier = new LieutenantGeneral(id, firstName, lastName, salary);

            foreach (var p in privates)
            {
                soldier.AddPrivate(p);
            }

            return soldier;
        }

        public Soldier GetSoldier(string id, string firstName, string lastName, decimal salary,
                                  string corps, string[] repairs)
        {
            Engineer soldier = new Engineer(id, firstName, lastName, salary, corps);

            for (int i = 0; i < repairs.Length; i += 2)
            {
                soldier.AddRepairs(repairs[i], int.Parse(repairs[i + 1]));
            }

            return soldier;
        }

        public Soldier GetSoldier(string id, string firstName, string lastName, string corps,
                                  decimal salary, string[] missons)
        {
            Commando soldier = new Commando(id, firstName, lastName, salary, corps);

            for (int i = 0; i < missons.Length; i += 2)
            {
                try
                {
                    soldier.AddMission(missons[i], missons[i + 1]);
                }
                catch (ArgumentException)
                {

                }

            }

            return soldier;
        }
    }
}
