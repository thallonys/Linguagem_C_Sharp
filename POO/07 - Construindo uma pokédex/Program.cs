using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7___Construindo_uma_pokédex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pokemon p = new Pokemon();
            p.Nome = "Bulbasauro";
            p.Descricao = "Bulbasauro é um pokémon tipo planta.";
            p.ExibirDadosPokemon();

            Console.ReadKey();
        }
    }
}
