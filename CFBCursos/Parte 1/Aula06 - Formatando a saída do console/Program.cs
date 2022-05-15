using System;

namespace Aula06___Formação_da_saída_do_Console
{
    class Aula06
    {
        static void Main(string[] args)
        {

            int n1, n2, n3;

            n1 = 10; n2 = 20; n3 = 30;

            double valorCompra = 5.50;
            double valorVenda;
            double lucro = 0.1;
            string produto = "Pastel";

            valorVenda = valorCompra + (valorCompra * lucro);

            // Em vez de contatenar, uso de indices
            Console.Write("n1 = {0}, n2 = {1}, n3 = {2}", n1, n2, n3);
            // Caracteres de escape: \n - quebra linha; \t - tabulação
            Console.WriteLine("\tn1 = {0}\n\t\tn2 = {1}\n\t\t\tn3 = {2}", n1, n2, n3);

            Console.WriteLine("Produto...........:{0,15}", produto);
            Console.WriteLine("Val.Compra........:{0,15:c}", valorCompra);
            Console.WriteLine("Lucro.............:{0,15:p}", lucro);
            Console.WriteLine("Val.Venda.........:{0,15:c}", valorVenda);

            /*
                O 15 depois do índice zero indica um tipo de espaçamento.
                :C - indica formatação em formato dinheiro.
                :p - indica formatação em formato porcentagem.
            */
        }
    }
}
