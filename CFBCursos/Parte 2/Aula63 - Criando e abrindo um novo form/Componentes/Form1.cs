using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Primeiramente é necessáiro verificar se existe algum texto para ser inserido no text box.
            // Assim, usa-se o if para verificar se o text box veículo está vazio. Se, sim, uma mensagem aparece.
            if (txtVeiculo.Text == "")
            {
                // Para mostrar uma caixa com uma mensagem é utilizado o comanado abaixo.
                MessageBox.Show("Digite um Veículo"); // Esse comando tem 22 sobrecargas. Ou seja, opções de uso.
                txtVeiculo.Focus(); // Essa função sempre coloca o foco no text box veiculo.
                                    // Dessa forma, quando aparecer o MessageBox e em seguida ele desaparecer, a função focus() irá mostrar o cursos piscante no text box.
                return;
            }
            else
            {
                // Esta declaração faz com que o text box lista veiculos receba o text box veiculos.
                // txtListaVeiculos.Text = txtVeiculo.Text;
                // Porém, toda vez que um novo texto é adicionado, o anterior é sobrescrito pelo novo texto.


                // Para resolver esse problema é feito o seguinte comando:
                // txtListaVeiculos.Text = txtListaVeiculos.Text + txtVeiculo.Text;
                // Aqui há a contatenação dos textos. Ou seja, o texto anteriro é somando com o novo texto e, assim, atribuido a variável.

                // Uma forma resumida de fazer essa contatenação é a seguinte:
                txtListaVeiculos.Text += txtVeiculo.Text + ", ";

                // --------------------
                
                // Ápós feito os comandos de inclusão de texto, agora é preciso limpar o texto box Veiculos e manter o foco nele.
                // Então:
                
                txtVeiculo.Clear(); // Função que limpa.
                txtVeiculo.Focus(); // Função que mantem o foco.
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // No botão de limpar, vem as seguintes funções.
            txtListaVeiculos.Clear(); // Função que limpa o text box lista.
            txtVeiculo.Clear(); // Função que limpa o text box veiculo.
            txtVeiculo.Focus(); // Função que mantem o foco no text bom Veiculo.
        }
    }
}
