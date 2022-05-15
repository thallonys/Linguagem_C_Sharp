using System;

namespace Aula04___Escopo_de_variáveis
{
    class Aula04
    {
        // Escopo global
        static int num = 10;
        static void Main(string[] args)
        {
            int num2 = 0;
            Console.WriteLine(num);
        }
    }
}

// O escopo de variável é onde a variável fica visível a outras partes do programa.