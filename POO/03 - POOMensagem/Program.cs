using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___POOMensagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mensagem msg1, msg2;
            msg1 = new Mensagem();
            msg1.TextoMensgem = "Alô Mundo";
            Console.WriteLine(msg1.TextoMensgem);

            // msg1.ExibirMensagem();

            //msg2 = new Mensagem();
            //msg2.TextoMensagem = "Segundo Objeto";
            //msg2.ExibirMensagem();

            Console.ReadKey();

        }
    }
}
