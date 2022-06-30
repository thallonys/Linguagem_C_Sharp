using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio02
{
    public class Media
    {
        public float Nota1 { get; set; }
        public float Nota2 { get; set; }
        public float Nota3 { get; set; }
        public float MediaNota { get; set; }

        private float CalcularMedia()
        {
            return (this.Nota1 + this.Nota2 + this.Nota3) / 3;
        }

        public void ExibirNotas()
        {
            if (this.CalcularMedia() >= 0 && this.CalcularMedia() < 3)
            {
                Console.WriteLine($"A média das notas é {this.CalcularMedia()} e situação é de Reprovado.");
            }
            else if (this.CalcularMedia() >= 3 && this.CalcularMedia() < 7)
            {
                Console.WriteLine($"A média das notas é {this.CalcularMedia()} e situação é de Exame.");
                Console.WriteLine($"A nota do exame que deve ser tirada é {12 - this.CalcularMedia()}.");
            }
            else if (this.CalcularMedia() >= 7 && this.CalcularMedia() <= 10)
            {
                Console.WriteLine($"A média das notas é {this.CalcularMedia()} e situação é de Aprovado.");
            }

        }
    }
}
