using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7___Construindo_uma_pokédex
{
    public class Pokemon
    {
        public Pokemon()
        {
            this.Nome = "";
            this.Descricao = "";
        }

        private String nome;

        public String Nome
        {
            get { return nome; }
            set 
            {
                String texto = value.ToUpper();
                nome = texto; 
            }
        }

        private String descricao; // armazena o valor da propriedade Descricao

        public String Descricao // representa a caracteristica Descrição do meu Podemon
        {
            get { return descricao; }
            set { descricao = value.ToUpper(); }
        }

        public void ExibirDadosPokemon()
        {
            Console.WriteLine("Nome do Pokémon: " + this.Nome);
            Console.WriteLine("Descrição do Pokémon: " + this.Descricao);
        }


    }
}
