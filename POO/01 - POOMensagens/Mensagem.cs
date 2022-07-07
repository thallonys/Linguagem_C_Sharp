using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___POOMensagens
{
    internal class Mensagem // classe mensagem criada
    {
        // pode criar objetos baseado na classe mensagem

        // reperesentação de característica por variáveis
        public String TextoMensagem; // public é um modificador de acesso

        public void ExibirMensagem()
        {
            Console.WriteLine(this.TextoMensagem); // this indica que estou usando coisas do proprio objeto
        }
    }
}
