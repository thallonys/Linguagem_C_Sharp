using System;

namespace Aula52___Exceções___Try_Catch_Finally___P1
{
    class Aula52
    {
        static void Main(string[] args)
        {
            int n1, n2, res;
            res = n1 = n2 = 0;

            n1 = 10;
            n2 = 0;
            
            // Tratamento de erros.
            // Na necessidade de personalizar erros.

            // Quando uma operação for executada e essa operação tem potencial de ocorrer algum erro, é possível personlizar a mensagem de erro que aparece para o usuário.
            // Para essa personalização é usado o try{} catch{}:
            try // O try tenta executar as declarações em seu escopo. Se essas declarações forem verdadeiras, o programa executa sem mostrar nenhum erro ao usuário.
            {
                res = n1 / n2;
                Console.WriteLine("{0}/{1} = {2}", n1, n2, res);
            }
            // Porém, se as declarações do escopo do try não forem possíveis de serem verdadeiras, o catch passa a ser executado: 
            catch(Exception e)
            // Quando o catch é executado, é mostrado mensagem de erros para o usuário. Essas mensagens são personalizadas pelo programador.
            // E para personalizar "ainda mais" é possível que o catch intermedie a classe Exception (essa classe é responsável por mostrar os tipos de erros)
            // para mostrar o erro trazido pelo sistema. Assim, para que isso seja feito, uma variável que se torna do tipo Exception é declara como parâmetro de catch. (Linha 26)
            // Após essa construção "catch(Exption e)" (Linha 26) é possível usar nas mensagens abaixo:
            {
                // Aqui o programador personaliza a mensagem de erro e, pelo Exception, consegue mostrar também mensagens do sistema.

                Console.WriteLine("ERRO: {0}", e.Message); // Mensagem personalizada 1. Também mostrar a mensagem do sistema.
                Console.WriteLine("ERRO: {0}", e.GetType()); // Mensagem personalizada 2. Também mostra o tipo do erro dado pelo sistema.
            }
            

            
        }
    }
}
