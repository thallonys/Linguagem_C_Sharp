using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2___exercicioAreaTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo tri = new Triangulo();

            Console.Write("Informe o valor da base do triângulo: ");
            tri.BaseTri = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor da altura do triângulo: ");
            tri.AlturaTri = double.Parse(Console.ReadLine());

            tri.ExibirDados();

            Console.ReadKey();
        }
    }
}
