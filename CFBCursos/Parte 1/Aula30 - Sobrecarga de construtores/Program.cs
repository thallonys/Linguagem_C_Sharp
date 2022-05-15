using System;

namespace Aula30___Sobrecarga_de_construtores
{
    public class Jogador
    {
        public int energia;
        public bool vivo;
        public string nome;

        // Para um método ser o construtor é somente necessário esse método
        // ter o mesmo nome da classe.
        // O construtor serve para iniciarlizar o objeto. Se não for passado
        // o construtor, o C# vai construir um automaticamente.

        public Jogador()
        {
            energia = 100;
            vivo = true;
            nome = "Jogador";
        }
        public Jogador(string n)
        {
            energia = 100;
            vivo = true;
            nome = n;
        }

        public Jogador(string n, int e)
        {
            energia = 100;
            vivo = true;
            nome = n;
        }
        public Jogador(string n, int e, bool v)
        {
            energia = e;
            vivo = v;
            nome = n;
        }

        public void info()
        {
            Console.WriteLine("Nome jogador: {0}", nome);
            Console.WriteLine("Energia jogador: {0}", energia);
            Console.WriteLine("Estado jogador: {0}\n", vivo);
        }


        // Destrutor
        // O destrutor é chamado automaticamente ao término do programa.
        ~Jogador()
        {
            Console.WriteLine("Jogador foi destruido.");
        }

    }

    class Aula30
    {
        static void Main(string[] args)
        {
            Jogador j1 = new Jogador(); // new aloca a memória necessária para o objeto.
            Jogador j2 = new Jogador("Aurora");
            Jogador j3 = new Jogador("Aurora", 100);
            Jogador j4 = new Jogador("Bene", 0, false);


            j1.info();
            j2.info();
            j3.info();
            j4.info();
        }
    }
}

/*
Sobrecarga de construtores é um método para inicializar um objetos várias
vezes com valores diferentes. Essa diferença poderá ser usada dependendo
da necessidade.
*/