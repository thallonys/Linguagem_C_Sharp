using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerResolvido05
{
    internal class CalcularSalario
    {
        // Variáveis e propriedades de acesso
        private float salario;

        public float Salario
        {
            get { return this.salario; }
            set { this.salario = value; }
        }

        private double percentualAumento;

        public double PercentualAumento
        {
            get { return this.percentualAumento; }
            set { this.percentualAumento = value; }
        }

        private double valorAumento;

        public double ValorAumento
        {
            get { return this.valorAumento; }
            set { this.valorAumento = value; }
        }

        private double salarioNovo;

        public double SalarioNovo
        {
            get { return this.salarioNovo; }
            set { this.salarioNovo = value; }
        }

        // Método para manipulação das propriedades de acesso
        public void CalcularNovoSalario()
        {
            // Solicitar ao usuário o valor do salário e o valor da porcentagem
            Console.Write("Informe o salário: ");
            Salario = float.Parse(Console.ReadLine());

            Console.Write("Informe o valor da porcentagem de aumento: ");
            PercentualAumento = float.Parse(Console.ReadLine());

            // Cálculo
            ValorAumento = Salario * (PercentualAumento / 100);
            SalarioNovo = Salario + ValorAumento;

            // Exibir o valor de aumento e o novo salário
            Console.WriteLine("O valor de aumento é R$ " + ValorAumento + ".");
            Console.WriteLine("O valor do salário é R$ " + SalarioNovo + ".");
            Console.ReadKey();
        }
    }
}
