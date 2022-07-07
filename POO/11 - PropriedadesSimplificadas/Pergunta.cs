﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___PropriedadesSimplificadas
{
    public class Pergunta
    {
        public Pergunta()
        {
            this.Texto = "";
            this.Resposta = "";
        }

        public Pergunta(String texto, String resposta)
        {
            this.Texto = texto;
            this.Resposta = resposta;
        }
        public String Texto { get; set; }

        public String Resposta { get; set; }

    }
}
