using System;

namespace DateModifier
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var start = Console.ReadLine();
            var end = Console.ReadLine();

            Console.WriteLine(new DateModifier(start, end).DaysBetweenDate());
        }
    }
}
