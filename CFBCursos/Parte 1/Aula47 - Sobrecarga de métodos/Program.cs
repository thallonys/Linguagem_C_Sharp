using System;

namespace Aula47___Sobrecarga_de_métodos
{
    class Calc
    {
        public int soma(params int[] n)
        {
            int s = 0;
            for (int i = 0; i < n.Length; i++)
                s += n[i];
            return s;
        }

        public double soma(params double[] n)
        {
            int s = 0;
            for (int i = 0; i < n.Length; i++)
                s += n[i];
            return s;
        }
    }
    class Aula47
    {
        static void Main(string[] args)
        {
            double res;
            Calc calc = new Calc();

            res = calc.soma(10, 5, 3);

            Console.WriteLine(res);
        }
    }
}

// Sobrecarga de métodos permite uma certa diversificação de uso dependendo da necessidade.
// Desta forma, por exemplo, se há a necessidade de usar int e em outro momento double para executar um cálculo,
// é possível criar dois métodos com o mesmo nome, com um que recebe int e o outro double.
// E o que faz a diferenciação entre dois métodos de mesmo nome é o conteúdo de cada um que tem que ser diferente.

// Também é possível determinar diferentes quantidades de parâmetros para o método. A forma mais generalizada para
// essa tarefa é utilizar params.

// Recordando: params é um parâmetro que adiciona uma array para tornar a entrada de parâmetros à uma função de forma dinâmica.
// Ou seja, se há a necessidade de passar n parâmetros, a melhor ferramenta que aceita esse n é o params.

// A notação do params é: métodoQualquer(params int[]n)
// o int[]n refere-se a um array de inteiro; o n é nome desse array.