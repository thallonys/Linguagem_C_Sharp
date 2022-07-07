using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___POOMensagem
{
    public class Mensagem
    {
        // Encapsulamento: proteger essa característica (variável)
        private String TextoMensagem; // private não permite acesso de outras classes a essa característica

        public void ExibirMensagem()
        {
            Console.WriteLine(this.TextoMensagem);
        }

        // métodos de acesso
        public String getTextoMensagem()
        {
            return this.TextoMensagem;
        }

        public void setTextoMensagem(String valor)
        {
            this.TextoMensagem = valor.ToUpper();
        }
    }
}
