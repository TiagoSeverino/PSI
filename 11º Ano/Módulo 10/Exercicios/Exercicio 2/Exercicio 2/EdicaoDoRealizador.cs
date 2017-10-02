using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class EdicaoDoRealizador : Filme
    {
        public int Ano { get; set; }
        public string LinguagemOriginal { get; set; }
        public string Titulo { get; set; }
        public string Informação { get; set; }

        public string mostraInformação(){return "Filme: " + Titulo + ", Realizado em " + Ano + " Linguagem: " + LinguagemOriginal + " Descrição: " + Informação;}
    }
}
