using System;
using System.Collections.Generic;

namespace Aula55___Coleção_Dictionary
{
    class Aula55
    {
        static void Main(string[] args)
        {
            // chave e valor para o dictionary
            // Construtor do dictionary
            Dictionary<int, string> veiculos = new Dictionary<int, string>();
            veiculos.Add(10, "Carro");
            veiculos.Add(5, "Avião");
            veiculos.Add(0, "Navio");
            veiculos.Add(20, "Moto");
            veiculos.Add(15, "Patinete");


            // Agora, há metodos para a manipulação do dictionary
            // veiculos.Clear(); // limpa o dictionary

            veiculos.Remove(20);

            Console.WriteLine("Tamano do Dictionary: {0}", veiculos.Count);
            int chave = 20;
            if (veiculos.ContainsKey(chave))
            {
                Console.WriteLine("A chave {0} está na coleção.", chave);
            }
            else
            {
                Console.WriteLine("A chave {0} não está na coleção.", chave);
            }

            veiculos[15] = "Bicicleta"; // substitui um valor existente por outro.

            string value = "Bicicleta";
            if (veiculos.ContainsValue(value))
            {
                Console.WriteLine("O valor {0} está na coleção.", value);
            }
            else
            {
                Console.WriteLine("O valor {0} não está na coleção.", value);
            }

            // Outra forma de imprimir todos os elemntos
            Dictionary<int, String>.ValueCollection valores = veiculos.Values;
            foreach (string v in valores)
            {
                Console.WriteLine(v);
            }

            // Imprimir todos os elementos
            foreach (KeyValuePair<int, string> v in veiculos)
            {
                Console.WriteLine(v.Key);
            }
        }
    }
}

// Quando é necessário criar uma coleção de algo e fazer operações nessa coleção.