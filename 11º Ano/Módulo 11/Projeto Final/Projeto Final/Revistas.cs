using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    class Revista : Obra   
    {
        public string NomeEditor;

        public Revista(bool isDisponivel, string nomeMutuário, string data, string nomeBiblioteca, string nomeEditor) : base(isDisponivel, nomeMutuário, data, nomeBiblioteca)
        {
            NomeEditor = nomeEditor;
        }
    }
}
