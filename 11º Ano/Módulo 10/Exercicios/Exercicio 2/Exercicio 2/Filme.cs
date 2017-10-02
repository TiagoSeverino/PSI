using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    interface Filme
    {
        string Titulo { get; set; }
        int Ano { get; set; }
        string LinguagemOriginal { get; set; }
        string mostraInformação();
    }
}
