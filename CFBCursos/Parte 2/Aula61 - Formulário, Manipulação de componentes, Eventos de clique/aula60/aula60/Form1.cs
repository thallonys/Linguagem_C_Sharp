using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula60
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_texto_Click(object sender, EventArgs e)
        {
            // Versão 1
            /*
            // Ações do botão:
            // Ações do botão:
            // Ao clicar no botão, uma variável txt do tipo string:
            String txt;
            // já declarada irá receber o texto que foi digitado no text box pela propriedade Text.
            // Ou seja, a variável txt recbe o texbox pelo nome (tb_texto) e com a propridade Texto (que permite fazer get e set) atribui o texto.
            // pegando o conteúdo do elemento do form1 (tb_texto) com a propriedade Text.
            // O acesso à propriedade Text é feita com ponto depois do nome do form.
            // Assim:
            txt = tb_texto.Text;

            // Agora, o label com o nome lb_texto pela propriedade Text( que permite get, set) recebe o valor atribuido à variável text. 
            // Assim:
            lb_texto.Text = txt;
            */

            // Versão 2
            // O label lb_texto com propriedade Text (get, set) recebe o table tb_teexto com a propriedade Text (get, set).
            lb_texto.Text = tb_texto.Text;
        }
    }
}
