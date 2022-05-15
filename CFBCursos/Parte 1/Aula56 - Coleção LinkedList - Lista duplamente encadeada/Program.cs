using System;
using System.Collections.Generic;

namespace Aula56___Coleção_LinkedList___Lista_duplamente_encadeada
{
    class Aula56
    {
        static void Main(string[] args)
        {
            // Cria uma lista ligada transp do tipo estring
            // E já é feito o instanciamento dessa lista ligada
            LinkedList<string> transp = new LinkedList<string>();

            // add elementos na lista
            transp.AddFirst("Carro");
            transp.AddFirst("Avião");
            transp.AddFirst("Navio");
            transp.AddFirst("Motocicleta");

            transp.AddLast("Bicicleta");

            // Cria um nó auxiliar
            LinkedListNode<string> no;
            // Esse nó recebe um comando para procurar um valor
            no = transp.FindLast("Navio");
            // É possível apontar para o próximo transp.FindLast("Navio").Next
            // Ou apontor para o anterior transp.FindLast("Navio").Before 
            // É adicionado depois do no procurado o Patinete
            transp.AddAfter(no, "Patinete");
            // percorrer para imprimir os itens na lista
            no = transp.FindLast("Carro");
            transp.AddBefore(no, "Patins");

            // transp.Clear(); // Limpa toda lista

            if (transp.Find("Carro") == null)
            {
                Console.WriteLine("Não encontrado.");
            }
            else
            {
                Console.WriteLine("Elemento encontrado.");
            }

            // transp.Remove("Navio");
            transp.RemoveFirst();
            transp.RemoveLast();

            foreach (string t in transp)
            {
                Console.WriteLine("Transporte: {0}", t);
            }
        }
    }
}
