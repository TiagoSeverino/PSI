using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    class Video : Obra
    {
        public string NomeEditor;
        public string NomeRealizador;
        public string Titulo;
        public int AnoPublicação;

        public Video(bool isDisponivel, string nomeMutuário, string data, string nomeBiblioteca, string nomeEditor, string titulo, string nomeRealizador, int anoPublicação) : base(isDisponivel, nomeMutuário, data, nomeBiblioteca)
        {
            NomeEditor = nomeEditor;
            Titulo = titulo;
            NomeRealizador = nomeRealizador;
            AnoPublicação = anoPublicação;
        }
    }
}
