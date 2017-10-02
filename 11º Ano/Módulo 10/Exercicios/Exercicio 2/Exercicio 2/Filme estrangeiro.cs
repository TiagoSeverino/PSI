using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class Filme_estrangeiro : Filme
    {
        public int Ano { get; set; }
        public string LinguagemOriginal { get; set; }
        public string Titulo { get; set; }
        public string PaisOrigem { get; set; }
        public string Lingua { get; set; }

        public string mostraInformação() { return "Filme: " + Titulo + ", Realizado em " + Ano + " Linguagem: " + LinguagemOriginal + " Pais Origem: " + PaisOrigem + " Lingua: " + Lingua; }
    }
}
