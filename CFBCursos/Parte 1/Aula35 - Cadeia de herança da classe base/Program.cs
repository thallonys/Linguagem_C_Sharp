using System;

namespace Aula35___Cadeia_de_herança_da_classe_base
{
    class Veiculo // classe base
    {
        // Propriedades
        private int rodas;
        public int velMax;
        private bool ligado;

        // Construtores
        public Veiculo(int rodas)
        {
            this.rodas = rodas;
        }

        // Método
        public void ligar()
        {
            ligado = true;
        }

        // Método
        public void desligar()
        {
            ligado = false;
        }

        // Método
        public string getLigado()
        {
            // Operador ternário
            return (ligado ? "sim." : "não.");
            /*
            if (ligado)
            {
                return "sim";
            }
            else
            {
                return "não.";
            }
            */
        }
        
        // Método
        public int getRodas()
        {
            return rodas;
        }

        // Método
        public void setRodas(int rodas)
        {
            if(rodas < 0)
            {
                this.rodas = 0;
            }
            else if (rodas > 40)
            {
                this.rodas = 40;
            }
        }
    }

    // Outra classe
    class Carro : Veiculo // Classe derivada
    {
        // Propriedades
        public string nome;
        public string cor;

        // Construtor
        public Carro(string nome, string cor) : base(4)   // inicializar o construtor da base (Linha 11) na derivada.
                                                          // O uso do termo base() é referente a classe base.
                                                          // Ou seja, a classe base é Veiculo e a classe derivada
                                                          // é Carro.
        {
            desligar();
            // rodas = 4;
            velMax = 120;
            this.nome = nome;
            this.cor = cor;

        }
    }
    
    // Outra classe
    class CarroCombate : Carro    // Cadeira de herança: A classe CarroCombate se torna classe derivada
                                  // e a classe Carro se torna a classe base. Repare que na linha 49
                                  // a base é Veiculo e a derivada é Carro. Logo, essa relação entre
                                  // base e derivada é relativa ao contexto de aplicação desse recurso.
                                  // Ainda mais, em termo geral, a classe veículo é a base de todas as 
                                  // classes derivadas.
    {
        // Propriedade
        public int municao;

        // Construtor
        public CarroCombate() : base("Carro de Combate", "Verde")
        {
            municao = 100;
            setRodas(6);
        }
    }

    // Classe principal
    class Aula35
    {
        // Método principal
        static void Main(string[] args)
        {
            Carro c1 = new Carro("Rapidão", "Vermelho");
            CarroCombate cc1 = new CarroCombate();

            c1.ligar();

            Console.WriteLine("Cor: {0}", c1.cor);
            Console.WriteLine("Nome: {0}", c1.nome);
            Console.WriteLine("Rodas: {0}", c1.getRodas());
            Console.WriteLine("Vel.Max: {0}", c1.velMax);
            Console.WriteLine("Ligado: {0}", c1.getLigado());

            Console.WriteLine("----------------------------------");

            Console.WriteLine("Cor: {0}", cc1.cor);
            Console.WriteLine("Nome: {0}", cc1.nome);
            Console.WriteLine("Rodas: {0}", cc1.getRodas());
            Console.WriteLine("Vel.Max: {0}", cc1.velMax);
            Console.WriteLine("Ligado: {0}", cc1.getLigado());
            Console.WriteLine("Munição: {0}", cc1.municao);
        }
    }
}
