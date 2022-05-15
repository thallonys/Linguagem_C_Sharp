using System;

namespace Aula46___Métodos_que_retornam_objetos
{
    class Galinha
    {
        private string nomeGalinha;
        private int numOvo;

        public Galinha(string nomeGalinha)
        {
            this.nomeGalinha = nomeGalinha;
            numOvo = 0;
        }

        public Ovo botar()
        {
            return new Ovo();
        }
    }
    class Ovo
    {
        public Ovo()
        {
            Console.WriteLine("Ovo criado");
        }
    }
    class Aula46
    {
        static void Main(string[] args)
        {
            Galinha g1 = new Galinha("Galinha 1");
            Galinha g2 = new Galinha("Galinha 2");
            Galinha g3 = new Galinha("Galinha 3");
        
            g1.botar();
        
        }
    }
}
