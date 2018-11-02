using System;
using System.Collections.Generic;

namespace P06_Animals
{
    class StarUp // 83 / 100
    {
        static void Main(string[] args)
        {
            var animals = new List<Animals>();
            string command;

            while ((command = Console.ReadLine()?.ToLower()) != "beast!")
            {
                var info = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    switch (command)
                    {
                        case "dog":
                            animals.Add(new Dog(info[0], int.Parse(info[1]), info[2]));
                            break;
                        case "cat":
                            animals.Add(new Cat(info[0], int.Parse(info[1]), info[2]));
                            break;
                        case "frog":
                            animals.Add(new Frog(info[0], int.Parse(info[1]), info[2]));
                            break;
                        case "kittens":
                            animals.Add(new Kittens(info[0], int.Parse(info[1])));
                            break;
                        case "tomcat":
                            animals.Add(new Tomcat(info[0], int.Parse(info[1])));
                            break;
                        default:
                            throw new ArgumentException("Invalid input!");
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            animals.ForEach(a => Console.WriteLine(a));

        }
    }
}
