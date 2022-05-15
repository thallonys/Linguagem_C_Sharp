using System;

namespace Aula40___Classe_Sealed
{

    sealed class Veiculo
    {

    }

    class Carro : Veiculo
    {

    }
    class Aula40
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();
        }
    }
}

// Classe Sealed não permite que a classe seja selada.
