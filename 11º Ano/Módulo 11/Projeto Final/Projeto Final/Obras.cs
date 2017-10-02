using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    static class Obras
    {
        public static List<Obra> obras = new List<Obra>();

        public static void AddJornal(bool isDisponivel, string nomeMutuário, string data, string nomeBiblioteca, string nomeEditor)
        {
            obras.Add(new JornalPediódico(isDisponivel, nomeMutuário, data, nomeBiblioteca, nomeEditor));
        }

        public static void AddLivro(bool isDisponivel, string nomeMutuário, string data, string nomeBiblioteca, string nomeEditor, string titulo, string dataPublicação)
        {
            obras.Add(new Livro(isDisponivel, nomeMutuário, data, nomeBiblioteca, nomeEditor, titulo, dataPublicação));
        }

        public static void AddVideo(bool isDisponivel, string nomeMutuário, string data, string nomeBiblioteca, string nomeEditor, string titulo, string nomeRealizador, int anoPublicação)
        {
            obras.Add(new Video(isDisponivel, nomeMutuário, data, nomeBiblioteca, nomeEditor, titulo, nomeRealizador, anoPublicação));
        }

        public static void AddRevista(bool isDisponivel, string nomeMutuário, string data, string nomeBiblioteca, string nomeEditor)
        {
            obras.Add(new Revista(isDisponivel, nomeMutuário, data, nomeBiblioteca, nomeEditor));
        }
    }

    abstract class Obra
    {
        public bool IsDisponivel;
        public string NomeMutuário;
        public string Data;
        public string NomeBiblioteca;

        public Obra(bool isDisponivel, string nomeMutuário, string data, string nomeBiblioteca)
        {
            IsDisponivel = isDisponivel;
            NomeMutuário = nomeMutuário;
            Data = data;
            NomeBiblioteca = nomeBiblioteca;
        }
    }
}
