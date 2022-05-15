using System;

namespace Aula15___SWITCH_case
{
    class Aula15
    {
        static void Main(string[] args)
        {
            int tempo = 0;
            char escolha;
            Console.WriteLine("BH a Vitória/ES.");
            Console.WriteLine("Escolha o transporte: [a] = avião, [c] = carro, [o] = Ônibus");
            escolha = char.Parse(Console.ReadLine());

            switch(escolha)
            {
                case 'a':
                case 'A':
                    tempo = 50;
                    break;
                case 'c':
                case 'C':
                    tempo = 480;
                    break;
                case 'o':
                case 'O':
                    tempo = 660;
                    break;
                default:
                    tempo = -1;
                    break;
            }

            if (tempo < 0)
            {
                Console.WriteLine("Transporte indisponível.");
            }
            else
            {
                Console.WriteLine("Para o transporte escolhido o tempo é: {0} minutos", tempo);
            }
        }
    }
}
