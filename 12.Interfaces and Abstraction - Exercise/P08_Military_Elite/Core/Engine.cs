using MilitaryElite.Factories;
using MilitaryElite.Soldiers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite.Core
{
    public class Engine
    {
        private SoldierFactory factory;
        private List<Soldier> soldiers;

        public Engine()
        {
            factory = new SoldierFactory();
            soldiers = new List<Soldier>();
        }

        public void Run()
        {
            GetSoldiers();

            PrintSoldiers();
        }

        private void PrintSoldiers()
        {
            soldiers.ForEach(Console.WriteLine);
        }

        private void GetSoldiers()
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var info = input.Split();
                try
                {
                    string id = info[1];
                    string firstName = info[2];
                    string lastName = info[3];
                    decimal salary = decimal.Parse(info[4]);

                    switch (info[0])
                    {
                        case "Private":
                            soldiers.Add(factory.GetSoldier(id, firstName, lastName, salary));
                            break;
                        case "LieutenantGeneral":
                            soldiers.Add(factory.GetSoldier(id, firstName, lastName, salary, 
                                                         GetPrivates(info)));
                            break;
                        case "Engineer":
                            soldiers.Add(factory.GetSoldier(id, firstName, lastName, salary,
                                                         info[5], GetList(info)));
                            break;
                        case "Commando":
                            soldiers.Add(factory.GetSoldier(id, firstName, lastName, info[5],
                                                          salary, GetList(info)));
                            break;
                        case "Spy":
                            soldiers.Add(factory.GetSoldier(id, firstName, lastName, (int)salary));
                            break;
                    }
                }
                catch (ArgumentException)
                {

                }

            }
        }

        private string[] GetList(string[] info)
        {
            return info.Skip(6).ToArray();
        }

        private string[] GetPrivates(string[] info)
        {
            List<string> privates = new List<string>();

            for (int i = 5; i < info.Length; i++)
            {
                privates.Add(soldiers.FirstOrDefault(s => s.Id == info[i])?.ToString());
            }

            return privates.ToArray();
        }
    }
}
