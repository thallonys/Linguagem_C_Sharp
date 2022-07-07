using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___calculaIdade
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

        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Ano de nascimento: " + this.AnoNascimento);
            int idade = this.CalcularIdade();
            Console.WriteLine("Idade: " + idade);
        }

        private int CalcularIdade() // todo método deve ter um verbo
        {
            DateTime data = DateTime.Now; // Pega a data do sistema atual
            int ano = data.Year;
            int idade = ano - this.AnoNascimento;
            return idade;
        }

    }
}
