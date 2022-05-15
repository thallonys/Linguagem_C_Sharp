using System;

namespace Aula29___Construtores_e_Destrutores
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
        public Jogador(string n)
        {
            energia = 100;
            vivo = true;
            nome = n;
        }

        // Destrutor
        // O destrutor é chamado automaticamente ao término do programa.
        ~Jogador()
        {
            Console.WriteLine("Jogador foi destruido.");
        }

    }

    class Aula29
    {
        static void Main(string[] args)
        {
            string nome1;
            Console.Write("Digite o nome do jogador 1: ");
            nome1 = Console.ReadLine();
            Jogador j1 = new Jogador(nome1); // new aloca a memória necessária para o objeto.
            Jogador j2 = new Jogador("Aurora");

            j1.energia = 50;
            Console.WriteLine("Nome do jogador 1: {0}", j1.nome);
            Console.WriteLine("Nome do jogador 2: {0}", j2.nome);
        }
    }
}