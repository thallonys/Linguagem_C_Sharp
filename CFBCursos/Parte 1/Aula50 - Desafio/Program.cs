using System;

namespace Aula50___Desafio
{
    delegate int Op(params int[]n);
    class Mat
    {
        public static int soma(params int[]n)
        {
            int res = 0;
            for(int i = 0; i < n.Length; i++)
                res += n[i];
            return res;
        }

        public static int dobro(params int[]n)
        {
            int res = 0;
            for(int i = 0; i < n.Length; i++)
                res = n[i] * 2;
            return res;
        }

        public static int mult(params int[]n)
        {
            int res = 1;
            for(int i = 0; i < n.Length; i++)
                res *= n[i];
            return res;
        }
    }
    class Aula50
    {
        static void Main(string[] args)
        {
            int res;

            Op d1 = new Op(Mat.soma);
            res = d1(10,50);
            Console.WriteLine("Soma: {0}", res);

            d1 = new Op(Mat.dobro);
            res = d1(10);
            Console.WriteLine("Dobro: {0}", res);
            
            d1 = new Op(Mat.mult);
            res = d1(10,50);
            Console.WriteLine("Multiplicação: {0}", res);
        }
    }
}
