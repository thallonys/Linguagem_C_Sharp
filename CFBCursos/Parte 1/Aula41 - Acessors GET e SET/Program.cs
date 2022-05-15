using System;

namespace Aula41___Acessors_GET_e_SET
{

    class Carro
    {
        private int velMax;

        public int vm
        {
            get { return velMax; }   // Leitura
            set
            {
                if (value < 0)
                {
                    velMax = 0;
                }
                else if (value > 300)
                {
                    velMax = 300;
                }
                else 
                {
                    velMax = value;
                }
            }   // Escrita
        }

        //Construtor
        public Carro()
        {
            vm = 120;
        }

        // Método
        
    }
    class aula41
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();

            Console.WriteLine("Velocidade: {0}", c1.vm);
        }
    }
}

// Propriedades flexiveis
// Propriedade que se para com um método. Mistura dos dois.
// Permite alteração do private.