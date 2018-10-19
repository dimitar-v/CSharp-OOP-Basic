using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person(12);
            Person p3 = new Person("Ivan", 18);

            Console.WriteLine($"{p1.Name} - {p1.Age} old");
            Console.WriteLine($"{p2.Name} - {p2.Age} old");
            Console.WriteLine($"{p3.Name} - {p3.Age} old");
        }
    }
}
