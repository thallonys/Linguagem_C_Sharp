using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___POOMensagem
{
    public class Mensagem
    {
        // Encapsulamento: proteger essa característica (variável)
        //    private String TextoMensagem; // private não permite acesso de outras classes a essa característica

        //    public void ExibirMensagem()
        //    {
        //        Console.WriteLine(this.TextoMensagem);
        //    }

        //    // métodos de acesso
        //    public String getTextoMensagem()
        //    {
        //        return this.TextoMensagem;
        //    }

        //    public void setTextoMensagem(String valor)
        //    {
        //        this.TextoMensagem = valor.ToUpper();
        //    }

        // Variáveis são consideradas conteineres

        private String textoMensagem;

        // como criar propriedades
        public String TextoMensgem // a propriedade não armazena nenhum valor. Somente faz a representação
        {
            get
            {
                return this.textoMensagem;
            }

            set
            {
                this.textoMensagem = value.ToUpper(); // value representa o valor atribuido a variável.
            }
        }
    }
}
