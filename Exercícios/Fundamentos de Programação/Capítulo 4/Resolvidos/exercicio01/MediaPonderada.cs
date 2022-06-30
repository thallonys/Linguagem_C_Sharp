using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01
{
    internal class MediaPonderada
    {
        public float NotaTL { get; set; }
        public float PesoTL { get; set; }
        public float NotaAS { get; set; }
        public float PesoAS { get; set; }
        public float NotaEF { get; set; }
        public float PesoEF { get; set; }
        public float Media 
        { 
            get 
            { 
                return this.CalcularMedia(); 
            } 
        }

        public MediaPonderada(float peso1, float peso2, float peso3)
        {
            this.PesoTL = peso1;
            this.PesoAS = peso2;
            this.PesoEF = peso3;
        }

        private float CalcularMedia()
        {
            return (this.NotaTL * this.PesoTL + this.NotaAS * this.PesoAS + this.NotaEF * this.PesoEF) / (this.PesoTL + this.PesoAS + this.PesoEF);
             
        }

        public void ExibirMedia()
        {
            if (this.CalcularMedia() >= 8 || this.CalcularMedia() <= 10)
            {
                Console.WriteLine($"A média é: {this.Media} e conceito é A.");
            }
            else if (this.CalcularMedia() >= 7 || this.CalcularMedia() < 8)
            {
                Console.WriteLine($"A média é: {this.Media} e conceito é B.");
            }
            else if (this.CalcularMedia() >= 6 || this.CalcularMedia() < 7)
            {
                Console.WriteLine($"A média é: {this.Media} e conceito é C.");
            }
            else if (this.CalcularMedia() >= 5 || this.CalcularMedia() < 6)
            {
                Console.WriteLine($"A média é: {this.Media} e conceito é D.");
            }
            else if (this.CalcularMedia() >= 0 || this.CalcularMedia() < 5)
            {
                Console.WriteLine($"A média é: {this.Media} e conceito é E.");
            }
        }

       



    }
}
