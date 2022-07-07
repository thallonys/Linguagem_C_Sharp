using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1;
            float nota2;
            float nota3;
            float media;

            Console.Write("Entre com a nota 1: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("Entre com a nota 2: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.Write("Entre com a nota 3: ");
            nota3 = float.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine($"A média é {media}.");
            Console.ReadKey();
        }
    }
}
