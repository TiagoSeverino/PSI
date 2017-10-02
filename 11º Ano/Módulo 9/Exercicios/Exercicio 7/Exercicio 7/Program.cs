using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Autor tiago = new Autor("Tiago Severino", "24 de Outubro 1999", "2560-270", "Torres Vedras");
            Editora portoEditora = new Editora("Porto Editora", "Porto", "Rua dos Livros", "2611234567");

            Livro ruca = new Livro("lnbgysduipofs", "Ruca", tiago, portoEditora, 1439);

            Livro noddy = new Livro();

            noddy.setISBN("1234567891234");
            noddy.setNome("Noddy");
            noddy.setAutor(tiago);
            noddy.setEditora(portoEditora);
            noddy.setAnoPublicação(888);

            Console.ReadLine();
        }
    }
}
