using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___Construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula a idade de uma pessoa.");
            Console.Write("Nome da pessoa: ");
            String nome = Console.ReadLine();
            Console.Write("Ano de nascimento: ");
            int ano = int.Parse(Console.ReadLine());

            Pessoa p;
            p = new Pessoa(nome, ano);
            p.ExibirDados();
            
            //Console.Write("Nome da pessoa: ");
            //p.Nome = Console.ReadLine();

            //Console.Write("Ano de nascimento: ");
            //p.AnoNascimento = int.Parse(Console.ReadLine());
            ////p.ExibirDados();
            //Console.WriteLine(p.Idade);

            Console.ReadKey();
        }
    }
}

/*
 O que foi ensinado?

O construtor é um recurso que altera os valores de inicialização do objeto.

Quando um construtor não é especificado explicitamente, a linguagem cria um construtor altomaticamente.

Quando explicitado, é possível utiliza-lo para que no momento da criação do objeto, valores sejam passasdos
para serem atribuidos ao construtor.

O construtor é declarado com o modificador de acesso public mais o nome da classe mais parenteses: public Pessoa() {}.
 */