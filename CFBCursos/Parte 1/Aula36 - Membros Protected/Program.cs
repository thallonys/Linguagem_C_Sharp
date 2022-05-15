using System;

namespace Aula36___Membros_Protected
{
    class Veiculo // classe base
    {
        // Propriedades
        public int velAtual;
        private int velMax;         // Private permite somente acesso do objeto
        protected bool ligado;      // Protected permite o acesso somente pelas classes derivadas. Funciona como o private.

        public Veiculo(int velMax)
        {
            velAtual = 0;
            this.velMax = velMax;
            ligado = false;
        }

        public bool getLigado()
        {
            return ligado;
        }

        public int getVelMax()
        {
            return velMax;
        }
    }

    // Frizando: quando private é setado em alguma propriedade o acesso a este é somente permite dentro da classe de origem.
    // Assim, se há tentativas de acesso por outra classe, esse acesso não é possível.
    // Já o uso de protected, funciona parecido com private quando é setado em alguma propriedade. Porém, quando a classe de
    // origem do private é herdada, ou seja, ela se torna a classe base de uma classe derivada, o acesso é permitido. É permitido
    // somente nesse caso.

    class Carro : Veiculo
    {
        public string nome;
        public Carro(string nome, int vm) : base(vm)    // Para um parâmetro ir para o parametro do construtor da classe basica
                                                        // é necessário passar um parametro no construtor da classe derivada.
                                                        // Depois, incluir esse mesmo parametro na referência base como parametro Linha 23.
        {
            this.nome = nome;
            ligado = true;
        }
    }
    class Aula36
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro("Bonitão", 120);

            Console.WriteLine("Nome: {0}", carro.nome);
            Console.WriteLine("Vel.Máxima: {0}", carro.getVelMax());
            Console.WriteLine("Ligado: {0}", carro.getLigado());
        }
    }
}
