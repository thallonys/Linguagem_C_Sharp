using System;

namespace Aula31___Classe_Static
{
    // Classe static não permite instanciamento. E, logo, não permite 
    // construtores. Já na memória tem posição fixa.
    static public class Jogador
    {
        // Propriedades
        static public int energia;
        static public bool vivo;
        static public string nome;

        // Construtor
        static public void iniciar(string n)
        {
            energia = 100;
            vivo = true;
            nome = n;
        }

        static public void info()
        {
            Console.WriteLine("Nome jogador: {0}", nome);
            Console.WriteLine("Energia jogador: {0}", energia);
            Console.WriteLine("Estado jogador: {0}\n", vivo);
        }
    }

    public class Inimigo
    {
        // Propriedades
        static public bool alerta; // Adicionando static
        public string nome;

        // Construtor
        public Inimigo(string n)
        {
            alerta = false;
            nome = n;
        }

        // Método
        public void info()
        {
            Console.WriteLine(nome);
            Console.WriteLine(alerta);
            Console.WriteLine("------------------");
        }
    }
    class Aula31
    {
        static void Main(string[] args)
        {
            Jogador.iniciar("Bruno");
            Jogador.info();

            Inimigo i1 = new Inimigo("Doido");
            Inimigo i2 = new Inimigo("Maluco");
            Inimigo i3 = new Inimigo("Pirado");

            // O uso do static permite que uma propriedade seja usada
            // unicamente para setar os dados. OU seja, a propriedade é fixada
            // na memória e todos construtores ou métodos que a utilizam
            // irão sempre utilizar a mesma propriedade static.
            Inimigo.alerta = true;

            i1.info();
            i2.info();
            i3.info();

        }
    }
}