using System;

namespace Aula19___Loop_FOR___Estrutura_de_iteração
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] num = new int[10];

            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thallonys");
                Console.WriteLine("{0}", i);
            }
            */

            for (int i = 0; i < num.Length; i++) // num.Length forma mais segura e altomática para definir o tamanho do percurso do loop.
            {
                num[i] = 0;
            }


            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Valor de num na pos{0}: {1}", i, num[i]);
            }
        }
    }
}
