using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___ListandoPokemons
{
    public class Pokedex
    {
        public Pokedex()
        {
            this.InicializaLista();
        }

        private List<Pokemon> pokemons;

        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
        }

        private void InicializaLista()
        {
            // instanciar a lista
            this.pokemons = new List<Pokemon>();
            Pokemon p = new Pokemon("Bulbasauro", "Sua descrição");

            this.pokemons.Add(p);
            p = new Pokemon("Bulbasauro", "Pokémon tipo planta");
            this.pokemons.Add(p);
            p = new Pokemon("Mew", "Lendário Psíquico");
            this.pokemons.Add(p);
            p = new Pokemon("MewTwo", "Lendário Psíquico");
            this.pokemons.Add(p);
            p = new Pokemon("Giratina", "Lendário Fantasma");
            this.pokemons.Add(p);
            p = new Pokemon("Flygon", "Pokémon dragão");
            this.pokemons.Add(p);
            p = new Pokemon("Metagross", "Pokémon de metal");
            this.pokemons.Add(p);
            p = new Pokemon("Muk", "Pokémon de metal");
            this.pokemons.Add(p);
            p = new Pokemon("Metagross", "Pokémon tóxico");
            this.pokemons.Add(p);
            p = new Pokemon("Lucario", "Lutador lendário");
            this.pokemons.Add(p);
            p = new Pokemon("Paras", "Pokémon inseto");
        }

        public void ListarPokemons()
        {
            for (int i = 0; i < this.pokemons.Count; i++)
            {
                this.Pokemons[i].ExibirDadosPokemon();
                //Pokemon p = this.Pokemons[i];
                //p.ExibirDadosPokemon();
            }
        }
    }
}
