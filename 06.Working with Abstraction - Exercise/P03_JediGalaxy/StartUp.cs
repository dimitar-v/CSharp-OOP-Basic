using System;
using System.Linq;

namespace P03_JediGalaxy
{
    public class StartUp
    {
        public static void Main()
        {
            int[] sizes = GetCordinats(Console.ReadLine());

            Board field = new Board(sizes[0], sizes[1]);
            
            long sum = 0;

            string command;
            while ((command = Console.ReadLine()) != "Let the Force be with you")
            {
                int[] startEvil = GetCordinats(Console.ReadLine());

                Player evil = new Player(startEvil[0], startEvil[1]);

                while (evil.Row >= 0 && evil.Col >= 0)
                {
                    if (field.IsInside(evil.Row, evil.Col))
                    {
                        field.Matrix[evil.Row, evil.Col] = 0;
                    }

                    evil.Row--;
                    evil.Col--;
                }

                int[] startPlayer = GetCordinats(command);
                                
                Player player = new Player(startPlayer[0], startPlayer[1]);

                while (player.Row >= 0 && player.Col < field.Matrix.GetLength(1))
                {
                    if (field.IsInside(player.Row, player.Col))
                    {
                        sum += field.Matrix[player.Row, player.Col];
                    }

                    player.Col++;
                    player.Row--;
                }
            }

            Console.WriteLine(sum);
        }

        private static int[] GetCordinats(string str)
            => str.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
    }
}
