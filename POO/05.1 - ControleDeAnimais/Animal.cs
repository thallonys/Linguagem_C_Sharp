using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._1___ControleDeAnimais
{
    public class Animal
    {
        private String nome;

        public String Nome
        {
            get { return this.nome; }
            set { this.nome = value.ToUpper(); }
        }

        private String tipo;

        public String Tipo
        { // valores pré definidos pelo proprietário - cachorro, gato, peixe
            get { return this.tipo; }
            set 
            {
                if (value == "Cachorro" || value == "Gato" || value == "Peixe")
                { 
                    this.tipo = value;
                }
                else
                {
                    tipo = "Peixe";
                }
            }
        }


    }
}
