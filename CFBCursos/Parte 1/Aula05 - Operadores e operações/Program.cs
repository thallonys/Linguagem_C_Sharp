using System;

namespace Aula05___Operadores
{
    class Aula05
    {
        static void Main(string[] args)
        {
            int res = 10 + 5;
            
            // Operadores relacionais: >, <, >=, <=, ==, !=
            bool verdade = 10 < 5;  // verdadeiro ou falso.
            // & + AND / E
            // | = OR / OU
            bool mentira = (5 > 3) & (10 > 5);
            
            
            
            // Operadores de incremento e decremento: 
            /*
            int num = 10;
            num = num + 1;
            num += 1;   num*=2; equivale a num = num * 2;
            num++;
            */

            Console.WriteLine(res);
            Console.WriteLine(verdade);
            Console.WriteLine(mentira);
        }
    }
}
