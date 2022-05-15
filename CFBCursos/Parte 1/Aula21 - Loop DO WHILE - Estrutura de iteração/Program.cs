using System;

namespace Aula21___Loop_DO_WHILE___Estrutura_de_iteração
{
    class Aula21
    {
        static void Main(string[] args)
        {
            int num = 5;
            string senha = "123";
            string senhauser;
            int tentativas = 0;
            
            do
            {
                Console.Clear();
                Console.Write("Digite a senha: ");
                senhauser = Console.ReadLine();
                tentativas++;

            } while (senha != senhauser);

            Console.Clear();
            Console.WriteLine("Senha Correta, tentativas: {0}", tentativas);
            
        }
    }
}

// Do while garante que pelo menos os comandos serão executados uma vez.