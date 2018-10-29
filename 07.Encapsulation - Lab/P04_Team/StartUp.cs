using System;

namespace PersonsInfo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var team = new Team("SoftUni");

            var num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var player = new Person(input[0],
                                        input[1],
                                        int.Parse(input[2]),
                                        decimal.Parse(input[3]));

                team.AddPlayer(player);
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players.\n\r" +
                              $"Reserve team has {team.ReserveTeam.Count} players.");
        }
    }
}
