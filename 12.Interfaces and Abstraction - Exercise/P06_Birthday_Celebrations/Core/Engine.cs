using Birthday_Celebrations.Interfaces;
using Birthday_Celebrations.Factory;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Birthday_Celebrations.Core
{
    public class Engine
    {
        private BirthdateFactory factory;
        private List<IBirthable> birthables;

        public Engine()
        {
            factory = new BirthdateFactory();
            birthables = new List<IBirthable>();
        }

        public void Run()
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var info = input.Split();

                var type = info[0];

                if ( type == "Robot")
                {
                    continue;
                }
                
                IBirthable birthable;
                var name = info[1];
                if (type == "Pet")
                {
                    birthable = factory.CreateBirthable(type, name, info[2]);
                }
                else
                {
                    int age = int.Parse(info[2]);
                    birthable = factory.CreateBirthable(type, name, info[4], age, info[3]);
                }
                               
                birthables.Add(birthable);
            }

            var year = Console.ReadLine();

            birthables.Where(b => b.Birthdate.EndsWith(year))
                .ToList()
                .ForEach(b => Console.WriteLine(b.Birthdate));
        }
    }
}
