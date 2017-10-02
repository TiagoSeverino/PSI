using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    abstract class Pessoa
    {
        public string Nome, Endereço, Morada;

        public Pessoa(string nome, string endereço, string morada)
        {
            Nome = nome;
            Endereço = endereço;
            Morada = morada;
        }

        public abstract void DescrevePessoa();
    }
}
