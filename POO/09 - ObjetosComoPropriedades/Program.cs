using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___ObjetosComoPropriedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Pokedex pokedex = new Pokedex();
            Pokemon p = pokedex.Pokemons[1];
            p.ExibirDadosPokemon();
            Console.ReadKey();
        }
    }
}

/*
 O que foi ensinado?

Foi ensinao usar um objeto como propriedade.

Para isso ser feito, é necessário instanciar uma classe em outra classe que não seja a Program.cs.

Feito isso, é feito o instanciamento da classe que tem um objeto instanciado na classe program.cs.
 */