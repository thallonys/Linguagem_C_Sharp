using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___calculaIdade
{
    public class Pessoa
    {
        private int anoNascimento;

        public int AnoNascimento
        {
            get { return this.anoNascimento; }
            set { this.anoNascimento = value; }
        }

        private String nome;

        public String Nome
        {
            get { return this.nome; }
            set { this.nome = value.ToUpper(); }
        }

        // Vamos melhorar
        private int idade;

        public int Idade
        {
            get 
            {
                this.CalcularIdade();
                return this.idade; 
            }
            // o set foi apagado porque a intenção é somente mostrar a idade. Ou seja, não atribuir com o set.
        }

        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Ano de nascimento: " + this.AnoNascimento);
            this.CalcularIdade();
            Console.WriteLine("Idade: " + this.Idade);
        }

        private void CalcularIdade() // todo método deve ter um verbo
        {
            DateTime data = DateTime.Now; // Pega a data do sistema atual
            int ano = data.Year;
            this.idade = ano - this.AnoNascimento; // O this.idade atribui o valor diretamente na variável
        }

    }
}
