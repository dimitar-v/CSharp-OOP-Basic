namespace PokemonTrainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var trainers = new List<Trainer>();

            string input;
            while ((input = Console.ReadLine()) != "Tournament")
            {
                var info = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var trainerName = info[0];
                var pokemonName = info[1];
                var pokemonElement = info[2];
                var pokemonHealth = int.Parse(info[3]);

                if (!trainers.Exists(t => t.Name == trainerName))
                {
                    trainers.Add(new Trainer(trainerName));
                }

                trainers.Find(t => t.Name == trainerName)
                    .Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
            }

            while ((input = Console.ReadLine()) != "End")
            {
                trainers.ForEach(t => 
                {
                    if (t.Pokemons.Exists(p => p.Element == input))
                    {
                        t.NumberOfBadges++;
                    }
                    else
                    {
                        t.Pokemons.ForEach(p => p.Health -= 10);
                    }
                    t.Pokemons.RemoveAll(p => p.Health <= 0);
                });
            }

            foreach (var trainer in trainers.OrderByDescending(t => t.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}
