using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario;
            double aumento;
            double novoSalario;

            Console.Write("Entre com o valor do salário: ");
            salario = float.Parse(Console.ReadLine());

            aumento = 0.25;
            novoSalario = aumento * salario + salario;

            Console.WriteLine($"O valor do novo salário é {novoSalario}.");
            Console.ReadKey();
        }
    }
}
