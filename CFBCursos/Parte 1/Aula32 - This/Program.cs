using System;

namespace Aula32___This
{
    class Calculos
    {
        // Propriedades
        public int v1;
        public int v2;

        // Construtor
        public Calculos(int v1, int v2)
        {
            // O this deixa claro para a IDE que a variál a ser utilizada
            // é a do objeto (linhas 8 e 9). Assim, impossibilitando que
            // aconteça um erro ao "confundir" essas variáveis com os parâmetros
            // do construtor (linha 12).
            this.v1 = v1;
            this.v2 = v2;
        }

        // Método
        public int Somar()
        {
            return v1 + v2;
        }

    }
    class Aula32
    {
        static void Main(string[] args)
        {
            Calculos c = new Calculos(10, 2);

            Console.WriteLine(c.Somar());
        }
    }
}
