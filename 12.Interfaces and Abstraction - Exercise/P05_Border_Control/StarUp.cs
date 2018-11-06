using System;
using System.Collections.Generic;
using System.Linq;

namespace Border_Control
{
    public class StarUp
    {
        static void Main(string[] args)
        {
            List<IIdentifiable> everyone = new List<IIdentifiable>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var info = input.Split();
                Control control;

                if (info.Length == 2)
                {
                    control = new Robot(info[0], info[1]);
                }
                else
                {
                    int age = int.Parse(info[1]);
                    control = new Citizen(info[0], age, info[2]);
                }

                everyone.Add(control);
            }

            var fakeId = Console.ReadLine();

            everyone.Where(x => x.Id.EndsWith(fakeId))
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
