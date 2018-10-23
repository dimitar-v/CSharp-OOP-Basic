namespace FamilyTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static List<Person> people;
        public static void Main(string[] args)
        {
            var personInfo = Console.ReadLine();
            var relations = new List<string>();
            people = new List<Person>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                if (input.Contains("-"))
                {
                    relations.Add(input);
                }
                else
                {
                    AddPeople(input);
                }
            }

            foreach (var relation in relations)
            {
                var info = relation.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                Person parent = GetPerson(info[0]);
                Person child = GetPerson(info[1]);

                parent.Children.Add(child);
                child.Parents.Add(parent);
            }

            Person person = GetPerson(personInfo);

            Console.WriteLine(person.Name + " " + person.Birthday);

            Console.WriteLine("Parents:");
            foreach (var parent in person.Parents)
            {
                Console.WriteLine(parent.Name + " " + parent.Birthday);
            }

            Console.WriteLine("Children:");
            foreach (var child in person.Children)
            {
                Console.WriteLine(child.Name + " " + child.Birthday);
            }
        }

        private static Person GetPerson(string info)
        {
            if (info.Contains("/"))
            {
                return people.Where(p => p.Birthday == info).FirstOrDefault();
            }

            return people.Where(p => p.Name == info).FirstOrDefault();
        }

        private static void AddPeople(string input)
        {
            var args = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            people.Add(new Person(args[0] + " " + args[1], args[2]));
        }
    }
}
