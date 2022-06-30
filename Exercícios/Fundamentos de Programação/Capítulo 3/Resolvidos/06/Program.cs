using System;

namespace _06
{
    abstract class Notas
    {
        // Propriedades
        private float nota1;
        private float nota2;
        private float nota2;
        private float media;

        private float peso1;
        private float peso2;
        private float peso3;

        public float nota1 { get; set; }
        public float nota2 { get; set; }
        public float nota3 { get; set; }
        public float media { get; set; }
        public float peso1 { get; set; }
        public float peso2 { get; set; }
        public float peso3 { get; set; }

        prop
        // Construtor
        public Notas()
        {
            nota1 = 0;
            nota2 = 0;
            nota3 = 0;
            media = 0;

            peso1 = 0;
            peso2 = 0;
            peso3 = 0;
        }

        // Métdos
        public void Media()
        {
            med = n1 * p1 + n2 * p2 + n3 * p3 / (p1 + p2 + p3);

            Console.WriteLine("A média é {0}", med);
        }
    }
    class exercicio_06
    {
        static void Main(string[] args)
        {
            Notas nota1 = new Notas();
            nota1.media();
        }
    }
}
