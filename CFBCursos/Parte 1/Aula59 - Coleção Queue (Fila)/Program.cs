using System;
using System.Collections.Generic;

namespace Aula59___Coleção_Queue__Fila_
{
    class Aula59
    {
        static void Main(string[] args)
        {
            // string[] vs = {"Carro", "Moto", "Navio", "Avião"};
            Queue<string> veiculos = new Queue<string>();

            veiculos.Enqueue("Carro");
            veiculos.Enqueue("Moto");
            veiculos.Enqueue("Navio");
            veiculos.Enqueue("Avião");

            string v = "Patinete";
            if(veiculos.Contains(v))
            {
                Console.WriteLine("Veículo " + v + " encontrado.");
            }
            else
            {
                Console.WriteLine("Veículo " + v + " não encontrado.");
            }

            // veiculos.Clear();

            // Console.WriteLine("Primeiro Veículo " + veiculos.Dequeue());
            // Console.WriteLine("Primeiro Veículo " + veiculos.Dequeue());
            // Console.WriteLine("Primeiro Veículo " + veiculos.Peek());
            
            /*
            foreach(string veic in veiculos)
            {
                // v = veiculos.Dequeue();
                Console.WriteLine("Veiculo removido: " + veic);
            }
            */
            
            Console.WriteLine("Tamanho fila: " + veiculos.Count);
        
            while(veiculos.Count > 0)
            {
                Console.WriteLine(veiculos.Dequeue());
            }

            Console.WriteLine("Tamanho fila: " + veiculos.Count);
        
        }
    }
}
