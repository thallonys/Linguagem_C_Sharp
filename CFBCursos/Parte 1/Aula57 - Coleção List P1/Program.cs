using System;
using System.Collections.Generic;

namespace Aula57___Coleção_List_P1
{
    class Aula57
    {
        static void Main(string[] args)
        {
            List<string> carros = new List<string>();
            // List<string>carros2 = new List<string>();
            string[] carros2 = new string[10];

            carros.Add("Golf");
            carros.Add("HRV");
            carros.Add("Focus");
            carros.Add("Argo");

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

        }
    }
}

// Array dinâmico