using System;

namespace Aula09___Operações_de_Bitwise
{
    class Aula09
    {
        static void Main(string[] args)
        {
            int num = 10;
            int num2 = 10;
            num = num << 1; // variável num recebe seu próprio valor com bitwise que o dobrar 1 vez.
            num2 = num2 >> 1; // variável num recebe seu próprio valor com bitwise que o diminui pela metade.
            Console.WriteLine(num);
            Console.WriteLine(num2);
        }
    }
}

/*
Bitwise

<< dobra o valor
>> metade do valor

*/