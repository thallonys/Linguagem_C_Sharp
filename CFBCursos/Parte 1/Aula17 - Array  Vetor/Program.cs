using System;

namespace Aula17___Array__Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5;
            // Formas de declaração de um array de cinco elementos.
            int[] n = new int[5];
            // int[] num = new int[3]{55,77,99};
            int[] num = { 55, 77, 99 }; // Altomáticamente o tamanho do array é definido pela quantidade de itens.
            // int[] n = new int[3]{55,77,99,100}; // Nesse exemplo ocorre erro devido à atribuição ser maior do que o tamanho do array.
            string[] veiculos = new string[3];
            // tipos nome = inicialização passando o tamanho do array.

            veiculos[0] = "Carro";
            veiculos[1] = "Avião";
            veiculos[2] = "Navio";

            // Preenchimento.
            n[0] = 111;
            n[1] = 222;
            n[2] = 333;
            n[3] = 444;
            n[4] = 555;

            Console.WriteLine(num[2]);
        }
    }
}
