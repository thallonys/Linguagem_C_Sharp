using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("+------------------------------------------+\n" +
                              "|           Nota            |     Peso     |\n" +
                              "| Trabalho de laboratório   |      12      |\n" +
                              "| Avaliação semestral       |      03      |\n" +
                              "| Exame final               |      05      |\n" +
                              "+------------------------------------------+\n");

            Console.WriteLine("+----------------------------+\n" +
                              "| Média Ponderada | Conceito |\n" +
                              "|   [8.0, 10.0]   |    A     |\n" +
                              "|   [7.0, 8.0[    |    B     |\n" +
                              "|   [6.0, 7.0[    |    C     |\n" +
                              "|   [5.0, 6.0[    |    D     |\n" +
                              "|   [0.0, 5.0[    |    E     |\n" +
                              "+----------------------------+\n");

            MediaPonderada media = new MediaPonderada(2,3,5);

            Console.Write("Informe a nota do Trabalho de laboratório: ");
            media.NotaTL = float.Parse(Console.ReadLine());

            Console.Write("Informe a nota da Avaliação Semestral: ");
            media.NotaAS = float.Parse(Console.ReadLine());

            Console.Write("Informe a nota do Exame Final: ");
            media.NotaEF = float.Parse(Console.ReadLine());

            media.ExibirMedia();

            Console.ReadKey();
        }
    }
}
