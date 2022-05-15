using System;

namespace Aula49___Métodos_e_Variáveis_estáticas__Static_
{
    class Mat
    {
        public static double pi = 3.14;

        public static int dobro(int n)
        {
            return n * 2;
        }
    }
    class Aula49
    {
        static void Main(string[] args)
        {

            double vpi = Mat.pi;
            int num = 10;

            Console.WriteLine(vpi);
            Console.WriteLine(Mat.dobro(num));
        }
    }
}

// Faltou explicar a aplicação!!!
// Uma classe static ou seus membros quando declarados dessa forma não precisam ser estanciados.
// Porém, para que seja possível utilizar seu contúdo é necessário referêniar a classe. Ou seja,
// indicar de vem a variável. Por isso, que a notação fica: Mat.pi (Mat é a referência a classe Mat).
