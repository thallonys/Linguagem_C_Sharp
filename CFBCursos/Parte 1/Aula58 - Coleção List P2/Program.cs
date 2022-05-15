using System;
using System.Collections.Generic;

namespace Aula58___Coleção_List_P2
{
    class Aula58
    {
        static void Main(string[] args)
        {
            List<string> carros = new List<string>();
            // List<string>carros2 = new List<string>();
            string[] carros2 = new string[10];

            carros.Add("Golf");
            carros.Add("HRV");
            carros.Add("Focus");
            carros.Add("HRV");

            // Adiciona os elementos da lista carros no carros2
            // carros2.AddRange(carros);

            // carros.Clear();

            if (carros.Contains("Golf"))
            {
                Console.WriteLine("Está na lista.");
            }
            else
            {
                Console.WriteLine("Não encontrado.");
            }

            // carros.CopyTo(carros2,2);
            carros.Insert(1, "Cruze");

            int pos2 = carros.LastIndexOf("HRV");

            /*
            carros.RemoveAt(0);
            
            if (carros.Remove("Focus"))
            {
                Console.WriteLine("Focus removido.");
            }
            else
            {
                Console.WriteLine("Focus não removido.");
            }
            */

            // carros.Reverse();
            carros.Sort();

            int tamanho = carros.Count;
            carros.Capacity = 3;
            int capacidade = carros.Capacity;

            Console.WriteLine("Tamanho {0}", tamanho);
            Console.WriteLine("Capacidade {0}", capacidade);

            // Imprime a lista
            foreach (string c in carros)
            {
                Console.WriteLine("Carro: {0}", c);
            }


            // mostra a posição do objeto
            string k = "HRV";
            int pos = 0;
            pos = carros.IndexOf(k);
            Console.WriteLine("Carro {0} está na posição {1}", k, pos);
            Console.WriteLine("Último HRV está na posição {0}.", pos2);

        }
    }
}

// Array dinâmico