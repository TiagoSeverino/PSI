using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7
{
    class Autor
    {
        public string nome, dataNascimento, cpf, endereço;

        public Autor(string Nome, string DataNascimento, string Cpf, string Endereço)
        {
            nome = Nome;
            dataNascimento = DataNascimento;
            cpf = Cpf;
            endereço = Endereço;
        }
    }
}
