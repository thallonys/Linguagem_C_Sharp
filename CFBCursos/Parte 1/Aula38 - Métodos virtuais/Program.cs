using System;

namespace Aula38___Métodos_virtuais
{
    class Base
    {
        public Base()
        {
            Console.WriteLine("Construtor de classe Base.");
        }

        virtual public void info()
        {
            Console.WriteLine("Base.");
        }
    }

    class Derivada1 : Base
    {
        public Derivada1()
        {
            Console.WriteLine("Construtor da classe Derivada 1.");
        }

        override public void info()
        {
            Console.WriteLine("Derivada 1.");
        }
    }

    class Derivada2 : Derivada1
    {
        public Derivada2()
        {
            Console.WriteLine("Construtor da classe Derivada 2.");
        }

        override public void info()
        {
            Console.WriteLine("Derivada 2.");
        }
    }
    class Aula39
    {
        static void Main(string[] args)
        {
            Base Ref;
            Derivada1 derivada1 = new Derivada1();
            Derivada2 derivada2 = new Derivada2();
            /*
            derivada1.info();
            derivada2.info();
            */
            Ref = derivada1;
            derivada1.info();

            Ref = derivada2;
            derivada2.info();
        }
    }
}

// O método virtual é um recurso usado quando há necessidade de usar o mesmo
// método com o mesmo nome em outra classe quando há herança.
// Assim, na classe base o método recebe a configuração virtual e, na classe
// derivada, o método recebe override. Dessa forma é possível sobrescrever os 
// métodos.

// sobre Ref, precisa de mais explicação...