using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerResolvido04
{
    internal class CalculaSalario
    {
        // Variáveis e propriedade de acesso
        private float salario;

        public float Salario
        {
            get { return this.salario; }
            set { this.salario = value; }
        }

        private double porcentagem;

        public double Porcentagem
        {
            get { return this.porcentagem; }
            set { this.porcentagem = value; }
        }

        private double salarioNovo;

        public double SalarioNovo
        {
            get { return this.salarioNovo; }
            set { this.salarioNovo = value; }
        }

        // Método para a manipulãção das propriedades
        public void CalcularNovoSalario()
        {
            // Solicitar ao usuário o valor do salário
            Console.Write("Informe o salário: ");
            salario = float.Parse(Console.ReadLine());

            // Cálculo do salário
            Porcentagem = 0.25;
            SalarioNovo = Salario + (Salario * Porcentagem);

            // Exibir o valor do novo salário
            Console.WriteLine("O novo salário é de R$ " + SalarioNovo + ".");
            Console.ReadKey();
        }



    }
}
