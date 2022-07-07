using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2___exercicioAreaTriangulo
{
    public class Triangulo
    {

        private double baseTri;

        public double BaseTri
        {
            get { return baseTri; }
            set 
            { 
                if (value >= 0)
                { 
                    baseTri = value; 
                }
                else
                {
                    baseTri = 0;
                }
            }
        }

        private double alturaTri;

        public double AlturaTri
        {
            get { return alturaTri; }
            set 
            { 
                if (value >= 0)
                { 
                alturaTri = value; 
                }
                else
                {
                    alturaTri = 0;
                }
            }
        }

        private double valorArea;

        public double ValorArea
        {
            get { return this.CalcularArea(); }
            
        }

        private double CalcularArea()
        {
            this.valorArea = (this.BaseTri * this.AlturaTri / 2);
            return this.valorArea;
        }

        public void ExibirDados()
        {
            Console.WriteLine("O valor da base é: " + this.BaseTri);
            Console.WriteLine("O valor da altura é: " + this.AlturaTri);
            Console.WriteLine("O valor da área é: " + this.ValorArea);
        }

        public void Testes()
        {
            Console.WriteLine("O valor da área é: " + this.valorArea);
        }



    }
}
