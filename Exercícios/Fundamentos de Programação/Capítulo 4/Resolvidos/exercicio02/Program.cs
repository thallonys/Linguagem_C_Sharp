using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Media aluno1 = new Media();

            Console.WriteLine("\t|  Média aritmética   |  Mensagem   |\n" +
                              "\t| 0,0 | @----O | 3,0  |  Reprovado  |\n" +
                              "\t| 3,0 | @----O | 7,0  |  Exame      |\n" +
                              "\t| 7,0 | @----@ | 10,0 |  Aprovado   |\n");

            Console.Write(" Informe a nota 1: ");
            aluno1.Nota1 = float.Parse(Console.ReadLine());

            Console.Write(" Informe a nota 2: ");
            aluno1.Nota2 = float.Parse(Console.ReadLine());

            Console.Write(" Informe a nota 3: ");
            aluno1.Nota3 = float.Parse(Console.ReadLine());

            aluno1.ExibirNotas();

            Console.ReadKey();
        }
    }
}
