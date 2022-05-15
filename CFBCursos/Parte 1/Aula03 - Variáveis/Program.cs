using System;

namespace CFBCursos
{
    class Aula03
    {
        static void Main()
        {
            byte n1 = 10;                       // 0 e 255
            int num = 0;                        // Antigamente precisava inicalizar a variável com zero.
                                                // Pode também receber valores negativos.
            char letra = 'c';
            float valor = 5.3f;                 // f no final para relacionar com o padrão float.
            string nome = "Thallonys";          // Armazena uma "cade de caractere".

            var aux = 0;                        // Var não especifica um tipo de variável.
                                                // O tipo é definido pela atribuição ao compilar o programa.
            var aux1 = "Casa";                  // O primeiro var é do tipo inteiro; o segundo do tipo string. 

            int num1, num2, res = 0;

            num1 = 10;
            num2 = 2;
            res = num1 + num2;

            Console.WriteLine("A soma de " + num1 + " e " + num2 + " é igual a " + res + "."); // + para contatenar texto com a variável.
        }
    }
}
