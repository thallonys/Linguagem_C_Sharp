using System;

// namespaces tem a finalidade de organizar as classes. Por exemplo, não é possível ter duas classes com o mesmo nome, porém, quando há
// namespaces distintos que separam essas classes de mesmo nome, é possível ter duas classes com o mesmo nome.
// E para que seja possível o acesso a essas classes, primeiro deve-se especificar qual o namaspace em que a classe pertence.
namespace Aula54___Namespaces
{
    namespace Calc1
    {
        class Area
        {
            public static float Quad(float bas, float alt)
            {
                if (bas == 0 || alt == 0)
                {
                    throw new Exception("Base ou altura não podem ser igual a 0.");
                }
                return bas * alt;
            }
        }
    }

    namespace Calc2
    {
        class Area
        {
            public static float Quad(float bas, float alt)
            {
                if (bas == 0 || alt == 0)
                {
                    throw new Exception("Base ou altura não podem ser igual a 0.");
                }
                return bas * alt;
            }
        }
    }
    class Aula53
    {
        static void Main(string[] args)
        {
            float area = 0;

            try
            {
                // Para trabalhar com o namespace, deve-se declarar seu nome e a classe correspondente:
                area = Calc1.Area.Quad(0, 5F); // Exemplo de uso de namespace.
                // Aqui poderia ser também area = Calc2.Area.Quad(0, 5F);. Ou seja, o que muda é no namespace.
                Console.WriteLine("Área do quadrado: {0}", area);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO: {0}", e.Message);
            }
            finally
            {
                Console.WriteLine("Fim do processo.");
            }
        }
    }
}