using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1___exercicioMaiorIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1; 
            Pessoa p2; 
            Pessoa p3;

            Console.WriteLine("Determina qual pessoa é a mais velha.");
            
            // Leitura de dados da primeira pessoa
            Console.Write("Nome da 1ª pessoa: ");
            p1 = new Pessoa();
            p1.Nome = Console.ReadLine();
            Console.Write("Idade da 1ª pessoa: ");
            p1.Idade = int.Parse(Console.ReadLine());

            // Leitura de dados da segunda pessoa
            Console.Write("Nome da 2ª pessoa: ");
            p2 = new Pessoa();
            p2.Nome = Console.ReadLine();
            Console.Write("Idade da 2ª pessoa: ");
            p2.Idade = int.Parse(Console.ReadLine());

            // Leitura de dados da terceira pessoa
            Console.Write("Nome da 3ª pessoa: ");
            String nome = Console.ReadLine();
            Console.Write("Idade da 3ª pessoa: ");
            int idade = int.Parse(Console.ReadLine()); 
            p3 = new Pessoa(nome, idade);
            // lógica
            if ((p1.Idade > p2.Idade) && (p1.Idade > p3.Idade))
            {
                Console.WriteLine("A pessoa mais velha é: ");
                p1.ExibirDados();
            }
            else
            {
                if ((p2.Idade > p3.Idade) && (p2.Idade > p1.Idade))
                {
                    Console.WriteLine("A pessoa mais velha é: ");
                    p2.ExibirDados();
                }
                else
                {
                    if ((p3.Idade > p1.Idade) && (p3.Idade > p2.Idade))
                    {
                        Console.WriteLine("A pessoa mais velha é: ");
                        p3.ExibirDados();
                    }
                    else
                    {
                        Console.WriteLine("Todas as pessoas possuem a mesma idade.");
                    }
                }
            }

            Console.ReadKey();
        }
    
    }
}
