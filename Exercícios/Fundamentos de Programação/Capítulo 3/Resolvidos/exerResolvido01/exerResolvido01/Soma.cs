using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerResolvido01
{
    internal class Soma
    {
        // Variável 1
        private int numero1;

        // Propriedade de acesso 1
        public int Numero1
        {
            get { return this.numero1; }
            set { this.numero1 = value; }
        }

        // Variável 2
        private int numero2;

        // Propriedade de acess 2
        public int Numero2
        {
            get { return this.numero2; }
            set { this.numero2 = value; }
        }

        // Variável 3
        private int numero3;

        // Propiedade de acesso 3
        public int Numero3
        {
            get { return this.numero3; }
            set { this.numero3 = value; }
        }

        // Variável 4
        private int numero4;

        // Propriedade de acesso 4
        public int Numero4
        {
            get { return this.numero4; }
            set { this.numero4 = value; }
        }

        // Variável resultado
        private int resultado;

        // Propriedade de acesso Resultado
        public int Resultado
        {
            get { return this.resultado; }
            set { this.resultado = value; }
        }

        // Método para manipular as propriedades
        public void somar()
        {
            // Atribuição
            Console.Write("Insira o primeiro número: ");
            Numero1 = int.Parse(Console.ReadLine());

            Console.Write("Insira o segundo número: ");
            Numero2 = int.Parse(Console.ReadLine());

            Console.Write("Insira o terceiro número: ");
            Numero3 = int.Parse(Console.ReadLine());

            Console.Write("Insira o quarto número: ");
            Numero4 = int.Parse(Console.ReadLine());

            // Soma
            Resultado = Numero1 + Numero2 + Numero3 + Numero4;

            // Mostrar resultado
            Console.WriteLine("O resultado da soma é " + Resultado + ".");
            Console.ReadKey();
        }


    }
}
