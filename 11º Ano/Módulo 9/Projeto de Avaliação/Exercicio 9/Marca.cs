using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9
{
    class Marca
    {
        public string nome { get; set; }
        public string pais { get; set; }

        public Marca(string Nome, string Pais)
        {
            nome = Nome;
            pais = Pais;
        }
    }
}
