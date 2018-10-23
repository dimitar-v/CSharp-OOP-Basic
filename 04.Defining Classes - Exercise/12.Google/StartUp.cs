namespace Google
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var info = new Dictionary<string, Person>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var details = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var name = details[0];
                var category = details[1];

                if (!info.ContainsKey(name))
                {
                    info[name] = new Person(name);
                }

                switch (category)
                {
                    case "company":
                        info[name].Company.Name = details[2];
                        info[name].Company.Department = details[3];
                        info[name].Company.Salary = decimal.Parse(details[4]);
                        break;
                    case "car":
                        info[name].Car.Modle = details[2];
                        info[name].Car.Speed = int.Parse(details[3]);
                        break;
                    case "pokemon":
                        info[name].Pokemons.Add(new Pokemon(details[2], details[3]));
                        break;
                    case "parents":
                        info[name].Parents.Add(new Person(details[2], details[3]));
                        break;
                    case "children":
                        info[name].Children.Add(new Person(details[2], details[3]));
                        break;
                }
            }

            var person = Console.ReadLine();
            if (info.ContainsKey(person))
            {
                Console.Write(info[person]);
            }
        }
    }
}
