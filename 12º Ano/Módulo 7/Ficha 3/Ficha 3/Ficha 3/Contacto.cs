using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_3
{
    [Serializable]
    struct Contacto
    {
        public string nome;
        public string telemóvel;
        public string telefone;
        public string mail;
        public string morada;
        public string dataNascimento;

        public Contacto(string nome, string telemóvel, string telefone, string mail, string morada, string dataNascimento)
        {
            this.nome = nome;
            this.telemóvel = telemóvel;
            this.telefone = telefone;
            this.mail = mail;
            this.morada = morada;
            this.dataNascimento = dataNascimento;
        }
    }
}
