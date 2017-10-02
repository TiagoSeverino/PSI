using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    class Livro : Obra
    {
        public string NomeEditor;
        public string Titulo;
        public string DataPublicação;

        public Livro(bool isDisponivel, string nomeMutuário, string data, string nomeBiblioteca, string nomeEditor, string titulo, string dataPublicação) : base(isDisponivel, nomeMutuário, data, nomeBiblioteca)
        {
            NomeEditor = nomeEditor;
            Titulo = titulo;
            DataPublicação = dataPublicação;
        }
    }
}
