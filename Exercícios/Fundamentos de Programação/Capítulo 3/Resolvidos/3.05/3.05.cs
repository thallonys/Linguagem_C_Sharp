using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario;
            float percentualAumento;
            float valorAumento;
            float valorNovoSalario;

            Console.Write("Entre com o valor do salário: ");
            salario = float.Parse(Console.ReadLine());

            Console.Write("Entre com o percentual de aumento: ");
            percentualAumento = float.Parse(Console.ReadLine());

            valorAumento = percentualAumento / 100 * salario;
            valorNovoSalario = valorAumento + salario;

            Console.WriteLine($"O valor de aumento é de R$ {valorAumento}.");
            Console.WriteLine($"O valor do novo salário é de R$ {valorNovoSalario}.");
            Console.ReadKey();
        }
    }
}
