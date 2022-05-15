using System;

namespace Aula08___Lendo_valores_do_teclado
{
    class Aula08
    {
        static void Main(string[] args)
        {

            int v1, v2, soma = 0;
            string nome = "";

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Nome digitado: {0}", nome);

            Console.Write("Digite o primeiro valor: ");
            v1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            v2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A soma de {0} mais {1} é igual a {2}.", v1, v2, v1 + v2);
            
        }
    }
}
