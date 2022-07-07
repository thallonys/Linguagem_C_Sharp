using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___calculaIdade
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
            p.ExibirDados();

            Console.ReadKey();
        }
    }
}

/*
 O que foi ensinado?

Essa aula foi voltada para a prática por meio de exercício. Foi usado:
    1   -   O uso de propfull para a criação da variável encapsulada + a propriedade de acesso;
    2   -   Elabora método para exibir dados e para o cálculo da idade.

Esse exercício segui o que foi ensinado até a aula passada.
 */