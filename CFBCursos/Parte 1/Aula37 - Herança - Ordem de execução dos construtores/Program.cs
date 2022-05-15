using System;

namespace Aula37___Herança___Ordem_de_execução_dos_construtores
{
    class Base
    {
        public Base()
        {
            Console.WriteLine("Construtor de classe Base.");
        }
    }

    class Derivada1 : Base
    {
        public Derivada1()
        {
            Console.WriteLine("Construtor da classe Derivada 1.");
        }
    }

    class Derivada2 : Derivada1
    {
        public Derivada2()
        {
            Console.WriteLine("Construtor da classe Derivada 2.");
        }
    }
    class Aula38
    {
        static void Main(string[] args)
        {
            Derivada2 derivada2 = new Derivada2();
            
        }
    }
}

// A ordem de execução é da classe base até a última classe derivada. 