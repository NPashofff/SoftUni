using System.Collections.Generic;

namespace _07.Car_Salesman
{
    public class Trainers
    {        
        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> Pokemons { get; set; }

        public Trainers(string name, Pokemon pokemon)
        {
            Name = name;
            Badges = 0;
            Pokemons = new List<Pokemon>();
            Pokemons.Add(pokemon);
        }
     
       
    }
}