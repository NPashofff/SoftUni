using System;
using System.Collections.Generic;

namespace Raiding
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());            
            List<BaseHero> heroes = new List<BaseHero>();

            while (heroes.Count != n)            
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                if (type == "Druid")
                {
                    Druid druid = new Druid(name);
                    heroes.Add(druid);
                }
                else if (type == "Paladin")
                {
                    Paladin paladin = new Paladin(name);
                    heroes.Add(paladin);
                }
                else if (type == "Rogue")
                {
                    Rogue rogue = new Rogue(name);
                    heroes.Add(rogue);
                }
                else if (type == "Warrior")
                {
                    Warrior warrior = new Warrior(name);
                    heroes.Add(warrior);
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                }
            }

            int bossPower = int.Parse(Console.ReadLine());
            int gruPower = 0;

            foreach (var item in heroes)
            {
                Console.WriteLine(item.CastAbility());
                gruPower += item.Power;
            }

            if (gruPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
