using System;

namespace Aula53___Exceções___Try_Catch_Finally___P2
{
    class Area
    {
        public static float Quad(float bas, float alt)
        {
            if (bas == 0 || alt == 0)
            {
                // Aqui, na tentativa de calcular a área de um quadrado, a base e a altura não podem ser zero.
                // Dessa forma, se ocorrer de uma dessas condições ser zero há o erro de cálculo. Com isso, é possível criar um erro artifial pelo throw:
                throw new Exception("Base ou altura não podem ser igual a 0.");
                // O throw cria um novo Exception com a mensagem de erro acima.
            }
            return bas * alt;
        }
    }
    class Aula53
     {
        static void Main(string[] args)
        {
            float area = 0;
            
            try
            {
                // O método acima é chamado aqui.
                // Primeiro é passado dois parâmetros para depois o cálculo ser feito. Se o cálculo for executado corretamente, o finally é executado diretamente.
                // Ao contrário, o catch é executado antes do finally.
                area = Area.Quad(0, 5F);
                Console.WriteLine("Área do quadrado: {0}", area);
            } 
            catch(Exception e)
            {
                // Se o catch for executado, é mostrar a mensagem pernolizada ERRO: e depois a mensagem de erro do sistema dado pela variável e do tipo Exception.
                Console.WriteLine("ERRO: {0}", e.Message);
            }

            // ------------------------------
            // !!!Inicio dos comentários!!!
            // ------------------------------

            // O try{} catch{} tem uma terceira parte, o finally{}. O finally funciona como uma mensagem final personalizada pelo programador ao final do procedimento, não importanto se foi o try ou catch executado.
            // Assim:
            finally
            {
                Console.WriteLine("Fim do processo.");
            }
            
            // Além do finally, existe o throw. O throw cria um erro. Ou seja ele cria um erro artificial. Assim, a possibilidade de uso é mais flexível.
            // Exemplo de uso na linha 11.
        }
    }
}
