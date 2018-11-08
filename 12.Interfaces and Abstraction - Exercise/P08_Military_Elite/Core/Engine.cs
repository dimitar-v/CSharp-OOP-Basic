using MilitaryElite.Enums;
using MilitaryElite.Interfaces;
using MilitaryElite.Soldiers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite.Core
{
    public class Engine
    {
        private ICollection<ISoldier> soldiers;

        public Engine()
        {
            soldiers = new List<ISoldier>();
        }

        public void Run()
        {
            GetSoldiers();

            PrintSoldiers();
        }

        private void PrintSoldiers()
        {
            soldiers.ToList()
                .ForEach(Console.WriteLine);
        }

        private void GetSoldiers()
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var info = input.Split();

                string id = info[1];
                string firstName = info[2];
                string lastName = info[3];
                decimal salary = decimal.Parse(info[4]);

                switch (info[0])
                {
                    case "Private":
                        soldiers.Add(GetPrivate(id, firstName, lastName, salary));
                        break;
                    case "LieutenantGeneral":
                        soldiers.Add(GetLieutenantGeneral(id, firstName, lastName, salary, info));
                        break;
                    case "Engineer":
                        {
                            if (Enum.TryParse(info[5], out Corps corps))
                            {
                                soldiers.Add(GetEngineer(id, firstName, lastName, salary, corps, GetList(info)));
                            }
                        }
                        break;
                    case "Commando":
                        {
                            if (Enum.TryParse(info[5], out Corps corps))
                            {
                                soldiers.Add(GetCommando(id, firstName, lastName, salary, corps, GetList(info)));
                            }
                        }
                        break;
                    case "Spy":
                        soldiers.Add(GetSpy(id, firstName, lastName, (int)salary));
                        break;
                }
            }
        }

        private ISoldier GetPrivate(string id, string firstName, string lastName, decimal salary)
            => new Private(id, firstName, lastName, salary);

        private ISoldier GetSpy(string id, string firstName, string lastName, int codeNumber)
            => new Spy(id, firstName, lastName, codeNumber);

        private ISoldier GetLieutenantGeneral(string id, string firstName, string lastName, decimal salary, string[] info)
        {
            ILieutenantGeneral lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary);

            List<string> privates = new List<string>();

            for (int i = 5; i < info.Length; i++)
            {
                IPrivate privateSoldier = (IPrivate)soldiers.FirstOrDefault(s => s.Id == info[i]);
                lieutenantGeneral.AddPrivates(privateSoldier);
            }

            return lieutenantGeneral;
        }

        private ISoldier GetEngineer(string id, string firstName, string lastName, decimal salary,
                                     Corps corps, string[] repairs)
        {
            IEngineer engineer = new Engineer(id, firstName, lastName, salary, corps);

            for (int i = 0; i < repairs.Length; i += 2)
            {
                IRepair repair = new Repair(repairs[i], int.Parse(repairs[i + 1]));
                if (repair == null)
                {
                    continue;
                }
                
                engineer.AddRepair(repair);
            }

            return engineer;
        }

        private ISoldier GetCommando(string id, string firstName, string lastName, decimal salary,
                                     Corps corps, string[] missons)
        {
            Commando commando = new Commando(id, firstName, lastName, salary, corps);

            for (int i = 0; i < missons.Length; i += 2)
            {
                if (!Enum.TryParse(missons[i + 1], out State state))
                {
                    continue;
                }
               
                IMission mission = new Mission(missons[i], state);

                commando.AddMission(mission);
            }

            return commando;
        }

        private string[] GetList(string[] info)
        {
            return info.Skip(6).ToArray();
        }
    }
}
