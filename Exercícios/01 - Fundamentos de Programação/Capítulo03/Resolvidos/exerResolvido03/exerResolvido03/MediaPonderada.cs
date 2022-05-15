using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerResolvido03
{
    internal class MediaPonderada
    {
        // Declaração de variáveis e suas respectivas propriedades de acesso
        // Notas
        private float nota1;

        public float Nota1
        {
            get { return this.nota1; }
            set { this.nota1 = value; }
        }

        private float nota2;

        public float Nota2
        {
            get { return this.nota2; }
            set { this.nota2 = value; }
        }

        private float nota3;

        public float Nota3
        {
            get { return this.nota3; }
            set { this.nota3 = value; }
        }

        // Pesos
        private float peso1;

        public float Peso1
        {
            get { return this.peso1; }
            set { this.peso1 = value; }
        }

        private float peso2;

        public float Peso2
        {
            get { return this.peso2; }
            set { this.peso2 = value; }
        }

        private float peso3;

        public float Peso3
        {
            get { return this.peso3; }
            set { this.peso3 = value; }
        }

        private float media;

        public float Media
        {
            get { return this.media; }
            set { this.media = value; }
        }


        // Métodos para manipular as propriedades

        public void calcularMediaPonderada()
        {
            // Solicitar os pesos para o usuário
            Console.Write("Insira o valor do primeiro peso: ");
            Peso1 = float.Parse(Console.ReadLine());

            Console.Write("Insira o valor do segundo peso: ");
            Peso2 = float.Parse(Console.ReadLine());

            Console.Write("Insira o valor do terceiro peso: ");
            peso3 = float.Parse(Console.ReadLine());

            // Solicitação das notas para o usuário
            Console.Write("Insira o valor da primeira nota: ");
            Nota1 = float.Parse(Console.ReadLine());

            Console.Write("Insira o valor da segunda nota: ");
            Nota2 = float.Parse(Console.ReadLine());

            Console.Write("Insira o valor da terceira nota: ");
            Nota3 = float.Parse(Console.ReadLine());

            // Cálculo da média
            Media = (Nota1 * Peso1 + Nota2 * Peso2 + Nota3 * Peso3) / (Peso1 + Peso2 + Peso3);

            // Exibir Media Ponderada
            Console.WriteLine("A média ponderada é: " + Media + ".");
            Console.ReadKey();
        }
    }
}
