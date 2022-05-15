using System;

namespace Aula33___Public_vs_Private
{
    class Jogador
    {
        private int energia;
        private string nome;
        
        // Construtor
        public Jogador(string nome)
        {
            this.nome = nome;
            energia = 100;
        }

        public int getEnergia()
        {
            return energia;
        }

        public string getNome()
        {
            return nome;
        }

        public void setEnergia(int e)
        {
            if (e < 0)
            {
                if(energia + e < 0)
                {
                    energia = 0;
                }
                else
                {
                    energia += e;
                }
            }
            else if (e > 0)
            {
                if(energia + e > 100)
                {
                    energia = 100;
                }
                else
                {
                    energia += e;
                }
            }
        }
    }
    class Aula33
    {
        static void Main(string[] args)
        {
            Jogador j1 = new Jogador("Thallonys");

            j1.setEnergia(-150);

            Console.WriteLine("Nome: {0}", j1.getNome());
            Console.WriteLine("Energia: {0}", j1.getEnergia());
        }
    }
}

// Private só permite o uso por dentro da classe.
// Não é possível acessar fora da classe.