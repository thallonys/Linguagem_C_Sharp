using System;

namespace Aula39___Classes_e_métodos_abstrato
{
    // Classe base abstrada
    abstract class Veiculo  // Não é possível instanciar uma classe abstrata.
                            // Somente é possível utilizá-la em herança.
    {
        protected int velMaxima;
        protected int velAtual;
        protected bool ligado;

        // Construtor
        public Veiculo()
        {
            ligado = false;
            velAtual = 0;
        }

        public void setLigado(bool ligado)
        {
            this.ligado = ligado;
        }

        public int getVelAtual()
        {
            return velAtual;
        }

        abstract public void aceleracao(int mult);  // Método abstrato
                                                    // Seu uso é obrigatório somente na classe derivada.
                                                    // Assim, funciona como um guia para implementações
                                                    // na classe derivada do que é preciso declarar.
    }

    class Carro : Veiculo
    {
        public Carro()
        {
            velMaxima = 120;
        }

        override public void aceleracao(int mult)   // Aqui é onde ocorre a aplicação do método abstrato.
                                                    // Repare que no lugar de abstract há override.
        {
            velAtual += 10 * mult;
        }
    }
    class Aula39
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro();
            carro1.aceleracao(1);
            carro1.aceleracao(-1);

            Console.WriteLine(carro1.getVelAtual());
        }
    }
}

// Classe abstrata é uma base de referência
