using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___POOMensagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mensagem msg1, msg2;
            msg1 = new Mensagem();
            // msg1.TextoMensagem = "Alò mundo";
            msg1.setTextoMensagem("Alô mundo");
            Console.WriteLine(msg1.getTextoMensagem());
            
            // msg1.ExibirMensagem();

            //msg2 = new Mensagem();
            //msg2.TextoMensagem = "Segundo Objeto";
            //msg2.ExibirMensagem();

            Console.ReadKey();

        }
    }
}

/*
    O que foi ensinado?

Foi ensinado a ideia de encapsulamento que consiste na proteção da característica (varipavel)
da classe objeto.

Tendo em vista que antes a variável foi configurada como public e, assim, qualquer outra classe teria
acesso a essa variável. Poré, essa configuração não é segura. Para contornar essa situação vem a o
procedimento de encapsulamente que:
    1   -     Muda o método de acesso de public para private.
    2   -     Para que o acesso a essa variável privada seja feita é necessário criar dois métodos
              para ler e escrever nessa variável.
    3   -     Com isso vem o conseito de get e set. Get para ler e set para atribuir valores à varipavel.


 */