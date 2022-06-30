using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_NumeroMaior
{
    internal class NumeroMaior
    {
        private int numero1;

        public int Numero1
        {
            get { return numero2; }
            set
            {
                if (value > 0)
                {
                    numero1 = value;
                }
                else
                {
                    numero1 = 0;
                }
            }
        }

        private int numero2;

        public int Numero2
        {
            get { return numero2; }
            set 
            {
                if (value > 0)
                { 
                numero2 = value;
                }
                else
                {
                    numero2 = 0;
                }
            }
        }


        public void MostrarNumeroMaior()
        {
            if (this.Numero1 > this.Numero2)
            {
                Console.WriteLine($"O maior número é {this.Numero1}.");
            }
            else 
            {
                Console.WriteLine($"O maior número é {this.Numero2}.");
            }
        }

    }
}
