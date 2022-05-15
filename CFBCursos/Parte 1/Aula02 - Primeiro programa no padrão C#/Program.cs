// Para criar um novo arquivo com este template é necessário passar
// este comando: dotnet new console --framework net5.0
// no cmd.

using System;                                   // Biblioteca

namespace Aula02                                // Niveis de organização
{
    class Program                               // Classe principal
    {
        static void Main(string[] args)         // Método principal
                                                // string[] args são padrões de entrada.
        {
            Console.WriteLine("Hello World!");
            if (args.GetLength(0) > 0)
            {
                Console.Write(args.GetValue(0));
            }
        }
    }
}
