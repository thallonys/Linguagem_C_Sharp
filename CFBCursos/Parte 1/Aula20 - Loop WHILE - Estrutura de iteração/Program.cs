using System;

namespace Aula20___Loop_WHILE___Estrutura_de_iteração
{
    class Aula20
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            int i = 0;
            // int i = num.Length-1; o Length vai atribuir o valor 10, porém a variável só suporta 9. Por isso, o uso de -1.
            while (i < num.Length)
            {
                num[i] = 0;
                Console.WriteLine("Thallonys");
                Console.WriteLine(num[i]);
                i++;
            }
            Console.WriteLine("Fim do loop.");
        }
    }
}
