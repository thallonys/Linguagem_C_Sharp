using System;

namespace Aula25___Passagem_por_valor_e_por_referência
{
    class Aula25
    {
        static void Main(string[] args)
        {
            int num = 10;
            int num2 = 50;

            dobrar1(num);
            dobrar2(ref num2);

            Console.WriteLine(num);
            Console.WriteLine(num2);
        }

        static void dobrar1(int valor)
        {
            valor *= 2;
        }

        static void dobrar2(ref int valor) // Passagem por referência
        {
            valor *= 2;
        }
    }
}

// Passagem por referência ref int valor
// funciona como um ponteiro
// Usa o endereço da memória para alterar o valor da variável.
// A passagem por valor não faz isso.