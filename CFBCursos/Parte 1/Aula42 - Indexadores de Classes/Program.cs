using System;

namespace Aula42___Indexadores_de_Classes
{
    class Carro
    {
        // Propriedade
        // Esse tipo de propriedade funciona com indexação. Isso significa que, é possível
        // atribuir um array de valores à propriedade. Como é um array, e para ter o acesso correto,
        // é preciso acessar cada elemento do array por indice.
        private int[] velMax = new int[5]{80,120,160,240,300};

        // Por isso que o método de acesso tem essa cara: 
        // Indexador tem a cara de int this[]
        public int this[int i] // O int i dentro dos colchetes é o indice do indexador.
        {
            get { return velMax[i]; }   // Leitura
            set
            {
                if (value < 0)
                {
                    velMax[i] = 0;
                }
                else if (value > 300)
                {
                    velMax[i] = 300;
                }
                else 
                {
                    velMax[i] = value;
                }
            }   // Escrita
        }

        //Construtor
        public Carro()
        {
           // vm = 120;
        }

        // Método
        
    }
    class aula42
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();

           // c1[4] = 200;
            Console.WriteLine("Velocidade: {0}", c1[4]);
        }
    }
}

// Indexador é um membro de uma classe que permite os objetos da classe serem usados como arrays.
