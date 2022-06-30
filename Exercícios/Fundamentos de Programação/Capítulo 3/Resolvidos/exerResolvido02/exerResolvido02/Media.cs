using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerResolvido02
{
    internal class Media
    {
        // Variável 1
        private int nota1;

        // Propriedade de acesso 1
        public int Nota1
        {
            get { return this.nota1; }
            set { this.nota1 = value; }
        }

        // Variável 2
        private int nota2;

        // Propriedade de acesso 2
        public int Nota2
        {
            get { return this.nota2; }
            set { this.nota2 = value; }
        }

        // Variável 3
        private int nota3;

        // Propriedade de acesso 3
        public int Nota3
        {
            get { return this.nota3; }
            set { this.nota3 = value; }
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
        public void calcularMedia()
        {
            // Atribuição de valores
            Console.Write("Insira a primeira nota: ");
            Nota1 = int.Parse(Console.ReadLine());

            Console.Write("Insira a segunda nota: ");
            Nota2 = int.Parse(Console.ReadLine());

            Console.Write("Insira a terceira nota: ");
            Nota3 = int.Parse(Console.ReadLine());

            // Cálculo da média
            Resultado = (Nota1 + Nota2 + Nota3) / 3;

            // Mostrar resultado da média
            Console.WriteLine("O resultado da media é " + Resultado + ".");
            Console.ReadKey();
        }
    }
}
