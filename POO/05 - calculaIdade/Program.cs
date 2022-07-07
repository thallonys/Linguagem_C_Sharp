using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___calculaIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula a idade de uma pessoa.");
            Pessoa p = new Pessoa();
            Console.Write("Nome da pessoa: ");
            p.Nome = Console.ReadLine();

            Console.Write("Ano de nascimento: ");
            p.AnoNascimento = int.Parse(Console.ReadLine());
            //p.ExibirDados();
            Console.WriteLine(p.Idade);

            Console.ReadKey();
        }
    }
}
