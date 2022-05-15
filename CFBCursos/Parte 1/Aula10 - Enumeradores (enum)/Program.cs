using System;

namespace Aula10___Enumeradores__enum_
{
    class Aula10
    {
        // O enum é um tipo de struct que permite criar tipos de variáveis.
        // O enum é declarado dentro da classe.
        enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sábado};
        static void Main(string[] args)
        {

            DiasSemana ds = DiasSemana.Domingo;
            // DiasSemana ds2 = 3; Aqui ocorre erro por falta do casting para DiasSemana.
            // int ds = DiasSemana.Sexta; Aqui ocorre erro por falta do casting para inteiro.
            DiasSemana ds2 = (DiasSemana)3; // Se for usado indice, é necessário fazer o casting antes de usar o índice.
                            // Aqui é o casting.
                            // O casting funciona como um tipo de conversor.
            
            Console.WriteLine(ds);
        }
    }
}
