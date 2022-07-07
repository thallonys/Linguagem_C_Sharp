// Bibliotecas

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___POOMensagens // forma de agrupar
{
    internal class Program
    {
        static void Main(string[] args) // função que representa um método
        {
            // instanciar é dar vida ao objeto
            Mensagem msg1, msg2; // cria variável do tipo mensagem
            msg1 = new Mensagem(); // instancia a variável com new e o construtor Mensagem();
            // msg1. // o ponto permite visualizar as características dos objetos.

            // encapsulamento
            msg1.TextoMensagem = "Alô Mundo";
            msg1.ExibirMensagem();


            msg2 = new Mensagem();
            msg2.TextoMensagem = "Segundo objeto";
            msg2.ExibirMensagem();
            Console.ReadLine();
        }
    }
}

// O que foi ensinado?
/*
 Localização das bibliotecas;
Explicação do que é namespace; R: É modo de organização.
A classe principal.
O método principal que na realidade é um tipo de função.

- Criação de novas classes. 
    L   Uma nova classe permite criar objetos baseados nessa classe.
- A característica de cada classe é representada por meio de variáveis.

(Após ter a classe criada)
- Instanciamento da classe. Que é a ideia de dar vida ao objeto. Ou seja, é possível utilizar o
conteúdo da classe B em outro classe A, quando o instanciamento é fetio na classe A. (Geralmente a 
classe A é a classe principal).
    L   Os comandos para tal procedimento é declaro uma variável do tipo da classe que se deseja usar
        como objeto. Depois, atribuir a essa variavel o comando new (comando de criação de objeto) e 
        construtor (Que tem o mesmo nome da classe que se deseja usar como objeto).

- Modificadores de acesso
Qualquer contéúdo em uma classe, por padrão, é configurado para ser do tipo private. Esse tipo não
permite que outras classes tenham acesso a conteúdos que tenham essa configuração. Porém, ao trocar o
private por public, esses conteúdos passam a ser acessíveis pelas outras classes.

 */
