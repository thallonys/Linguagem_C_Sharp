using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1;
            float nota2;
            float nota3;
            float peso1;
            float peso2;
            float peso3;
            float media;

            Console.Write("Entre com a nota 1: ");
            nota1 = float.Parse(Console.ReadLine());
            Console.Write("Entre com o peso 1: ");
            peso1 = float.Parse(Console.ReadLine());

            Console.Write("Entre com a nota 2: ");
            nota2 = float.Parse(Console.ReadLine());
            Console.Write("Entre com o peso 2: ");
            peso2 = float.Parse(Console.ReadLine());

            Console.Write("Entre com a nota 3: ");
            nota3 = float.Parse(Console.ReadLine());
            Console.Write("Entre com o peso 3: ");
            peso3 = float.Parse(Console.ReadLine());

            media = (nota1 * peso1 + nota2 * peso2 + nota3 * peso3) / (peso1 + peso2 + peso3);

            Console.WriteLine($"A média é {media}.");
            Console.ReadKey();

        }
    }
}
