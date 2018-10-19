using System;

namespace OldestFamilyMember
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Family family = new Family();

            var num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                var inputs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var name = inputs[0];
                var age = int.Parse(inputs[1]);

                family.AddMember(new Person(name, age));
            }

            Person oldest = family.GetOldestMember();

            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}
