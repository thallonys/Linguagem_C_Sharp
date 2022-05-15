using System;

namespace Aula22___FOREACH___Estruturas_de_iteração
{
    class Aula22
    {
        static void Main(string[] args)
        {
            int[] num = new int[3]{11,22,33};

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = 0;
            }
            
            foreach(int n in num) 
            {
                Console.WriteLine(n);
            }
        }
    }
}

// foreach é indicado para quando for somente ler um array.