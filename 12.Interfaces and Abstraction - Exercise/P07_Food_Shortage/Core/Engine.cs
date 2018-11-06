using Food_Shortage.Classes;
using Food_Shortage.Factory;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Food_Shortage.Core
{
    public class Engine
    {
        PersonsFactory factory;
        List<Person> people;

        public Engine()
        {
            factory = new PersonsFactory();
            people = new List<Person>();
        }

        public void Run()
        {
            AddPeople();

            PeopleByeFood();

            PrintTotalFood();
        }

        private void AddPeople()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                var info = Console.ReadLine().Split();
                var name = info[0];
                var age = int.Parse(info[1]);

                if (info.Length == 4)
                {
                    people.Add(factory.CreatePerson(name, age, info[2], info[3]));
                }
                else if (info.Length == 3)
                {
                    people.Add(factory.CreatePerson(name, age, info[2]));
                }
            }
        }

        private void PeopleByeFood()
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                people.FirstOrDefault(p => p.Name == input)
                     ?.ByeFood();
            }
        }

        private void PrintTotalFood()
        {
            var totalFood = people.Sum(p => p.Food);

            Console.WriteLine(totalFood);
        }
    }
}
