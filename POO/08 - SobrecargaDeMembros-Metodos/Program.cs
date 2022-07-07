using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___SobrecargaDeMembros_Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pokemon p = new Pokemon("Bulbasauro", "Bulbasauro é um pokémon tipo planta.");
            p.ExibirDadosPokemon(true);
            p.ExibirDadosPokemon();

            Console.ReadKey();
        }
    }
}
