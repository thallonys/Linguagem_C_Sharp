using System;

namespace Aula51___Argumentos_de_entrada_do_programa
{
    class Aula51
    {
        static void Main(string[] args)
        {
            int res = 0;

            if (args.Length > 0)
            {
                Console.WriteLine("Quantidade de argumentos {0}", args.Length);
                for (int i = 0; i < args.Length; i++)
                {
                    res += Int32.Parse(args[i]);
                }
                Console.WriteLine("Soma: {0}", res);
            }
            else
            {
                Console.WriteLine("Não forma passados argumentos.");
            }
        }
    }
}

// Explicação do parâmetro do main e aplicações.
