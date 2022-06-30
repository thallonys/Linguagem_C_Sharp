using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_NumeroMaior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumeroMaior numero = new NumeroMaior();
            int opcao = 0;
            Console.WriteLine("Mostrar qual é o maior número entre dois números.");

            do
            {
                Console.Write("Informe o número 1: ");
                numero.Numero1 = int.Parse(Console.ReadLine());

                Console.Write("Informe o número 2: ");
                numero.Numero2 = int.Parse(Console.ReadLine());

                numero.MostrarNumeroMaior();

                Console.WriteLine("Tecle 1 para continuar ou 0 para sair.");
                opcao = int.Parse(Console.ReadLine());

                Console.Clear();

            } while (opcao == 1);

                Console.ReadKey();

        }
    }
}
