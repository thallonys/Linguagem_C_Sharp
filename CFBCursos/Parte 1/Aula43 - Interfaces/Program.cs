using System;

namespace Aula43___Interfaces
{
    public interface Veiculo // declaração de interface
    {
        void ligar(); // Somente a assinatura
        void desligar();
        void info();
    }

    public interface Combate
    {
        void disparar();
    }

    class Carro : Veiculo, Combate
    {
        public bool ligado;
        public int municao;
        public Carro()
        {
            setMunicao(100);
        }

        public void setMunicao(int qtde)
        {
            this.municao = qtde;
        }
        public void ligar()
        {
            this.ligado = true;
        }

        public void desligar()
        {
            this.ligado = false;
        }

        public void disparar()
        {

        }
        public void info()
        {

        }
    }
    class Aula43
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();
        }
    }
}

// Interfaces, semelhança com classe abstratic.
// Somente implementam os protóripos dos métodos.
// Uma classe pode implementar mais de uma interface.
