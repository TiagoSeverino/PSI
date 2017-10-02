using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7
{
    class Livro
    {
        private string ISBN, nome;
        private Autor autor;
        private Editora editora;
        private int anoPublicação;

        public Livro()
        {
            
        }

        public Livro(string _ISBN, string Nome, Autor Autor, Editora Editora, int AnoPublicação) : this()
        {
            this.setISBN(_ISBN);
            this.setNome(Nome);
            this.setAutor(Autor);
            this.setEditora(Editora);
            this.setAnoPublicação(AnoPublicação);
        }

        public void setISBN(string _ISBN)
        {
            if (_ISBN.Length == 13)
                ISBN = _ISBN;
        }

        public string getISBN() { return ISBN;}

        public void setNome(string Nome) { nome = Nome; }

        public string getNome() { return nome; }

        public void setAutor(Autor Autor) { autor = Autor; }

        public Autor getAutor() { return autor; }

        public void setEditora(Editora Editora) { editora = Editora; }

        public Editora getEditora() { return editora; }

        public void setAnoPublicação(int AnoPublicação)
        {
            if (AnoPublicação < 2014)
                anoPublicação = AnoPublicação;
        }

        public int getAnoPublicação() { return anoPublicação; }
    }
}
