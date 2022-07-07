using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___ListandoPokemons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();
            int resp = 100;
            while (resp != 0)
            {
                resp = Menu();

                if(resp == 1)
                {
                    pokedex.ListarPokemons();
                }

                Console.ReadKey();
                Console.Clear();
            }
            
        }

        static int Menu()
        {
            Console.WriteLine("\tPokédex ---- Agenda Pokémon\n" +
                              "\t0 - Sair da Pokédex\n" +
                              "\t1 - Listar todos os Pokémons\n");
            Console.Write(" O que você deseja fazer: ");
            int resp = int.Parse(Console.ReadLine());
            return resp;


        }
    }
}
