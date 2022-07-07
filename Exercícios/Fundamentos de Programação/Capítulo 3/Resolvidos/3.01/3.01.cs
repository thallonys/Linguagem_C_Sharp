using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;
            int w;
            int soma;

            Console.Write("Entre com o primeira inteiro: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Entre com o segundo inteiro: ");
            y = int.Parse(Console.ReadLine());

            Console.Write("Entre com o terceiro inteiro: ");
            z = int.Parse(Console.ReadLine());

            Console.Write("Entre com o quarto inteiro: ");
            w = int.Parse(Console.ReadLine());

            soma = x + y + z + w;

            Console.WriteLine($"O total da soma é {soma}.");
            Console.ReadKey();
        }
    }
}
