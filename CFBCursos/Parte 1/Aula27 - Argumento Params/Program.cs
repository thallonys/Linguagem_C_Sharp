using System;

namespace Aula27___Argumento_Params
{
    class Aula27
    {
        static void Main(string[] args)
        {
            soma(10, 5, 7, 8, 9);
        }

        static void soma(params int[] n)
        {
            int res = 0;

            if (n.Length < 1)
            {
                Console.WriteLine("Valores insuficientes.");
            }
            else if (n.Length < 2)
            {
                Console.WriteLine("Valores insuficientes para a soma: {0}", n[0]);
            }
            else
            {
                for (int i = 0; i < n.Length; i++)
                {
                    // A soma ocorrerá para cada passada do loop.
                    res += n[i];
                }
                Console.WriteLine("A soma dos valores é: {0}", res);
            }
        }
    }
}

// params permite passar parâmetros de uma dorma dinâmica (linha 12)
// params funciona com arrays.