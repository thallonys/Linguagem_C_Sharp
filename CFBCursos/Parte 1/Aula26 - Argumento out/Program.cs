using System;

namespace Aula26___Argumento_out
{
    class Aula26
    {
        static void Main(string[] args)
        {
            int dividendoMain, divisorMain, quocienteMain, restoMain;
            dividendoMain = 10;
            divisorMain = 5;
            quocienteMain = divide(dividendoMain, divisorMain, out restoMain);

            Console.WriteLine("{0} / {1}: quociente = {2} e resto = {3}", dividendoMain, divisorMain, quocienteMain, restoMain);
        }

        static int divide(int dividendo, int divisor, out int resto)
        {
            int quociente;
            quociente = dividendo / divisor;
            resto = dividendo % divisor;
            return quociente;

            // retornar o resto da divisão
            // Para, nesse caso, retornar o resto da divisão é necessário usar
            // o comando out no parâmetro (veja exemplo linha 17). E, também indicar o out
            // no chamento do método (veja exemplo linha 12). Assim, é possível
            // ter duas saídas para o método.
        }

    }
}