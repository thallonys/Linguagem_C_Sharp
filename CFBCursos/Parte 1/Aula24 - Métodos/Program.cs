using System;

namespace Aula24___Métodos
{
    class Aula24
    {
        static void Main(string[] args) // Método principal
        {
            int v1, v2 = 0;

            v1 = Convert.ToInt32(Console.ReadLine());
            v2 = Convert.ToInt32(Console.ReadLine());

            eu();
            soma(v1, v2);
        }

        static void eu()
        {
            Console.WriteLine("Thallonys");
        }

        static void soma(int n1, int n2)
        {
            int res = n1 + n2;
            Console.WriteLine("A soma de {0} e {1} é: {2}", n1, n2, res);

        }
    }
}

// Métodos conjuntos de instruções
// Agrupar uma série de instruções