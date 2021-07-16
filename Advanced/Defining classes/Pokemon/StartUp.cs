using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Car_Salesman
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainers> trainers = new Dictionary<string, Trainers>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Tournament")
                {
                    break;
                }

                string[] tockens = input.Split();
                string teanerName = tockens[0];
                Pokemon pokemon = new Pokemon(tockens[1], tockens[2], int.Parse(tockens[3]));
                Trainers trainer = new Trainers(teanerName, pokemon);

                if (trainers.ContainsKey(teanerName))
                {
                    trainers[teanerName].Pokemons.Add(pokemon);
                }
                else
                {
                    trainers.Add(teanerName, trainer);
                }

            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                foreach (var trener in trainers)
                {
                    bool isElement = false;

                    foreach (var pokemon in trener.Value.Pokemons)
                    {
                        if (pokemon.Element == input)
                        {
                            isElement = true;
                        }
                    }

                    if (isElement)
                    {
                        trener.Value.Badges++;
                    }
                    else
                    {
                        foreach (var pokemon in trener.Value.Pokemons)
                        {
                            pokemon.Health -= 10;  
                            
                        }

                        for (int i = 0; i < trener.Value.Pokemons.Count; i++)
                        {
                            if (trener.Value.Pokemons[i].Health <= 0)
                            {
                                trener.Value.Pokemons.RemoveAt(i);
                                i = 0;
                            }
                        }
                    }                   
                }

            }
            LinkedList<string> list = new LinkedList<string>();
            
            foreach (var item in trainers.OrderByDescending(x => x.Value.Badges))
            {
                Console.WriteLine($"{item.Key} {item.Value.Badges} {item.Value.Pokemons.Count}");
            }
        }
    }
}