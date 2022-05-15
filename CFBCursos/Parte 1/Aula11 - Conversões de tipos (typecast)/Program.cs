using System;

namespace Aula11___Conversões_de_tipos__typecast_
{
    class Aula11
    {
        static void Main(string[] args)
        {
            // Aqui ocorre um conversão implicita de int para float.
            int ex1 = 10;
            float ex2 = ex1;

            float ex4 = 10.5f;
            // int ex5 = ex4; Dessa forma não funciona.
            int ex5 = (int)ex4; // Operação de conversão type cast

            int ex6 = 10;
            // short ex7 = ex6; Não funciona
            short ex7 = (short)ex6; // Para funcionar precisa de type cast.

            Console.WriteLine(ex2);
            Console.WriteLine(ex5);
            Console.WriteLine(ex7);
        }
    }
}
