using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Exercicio_8
{
    class Agenda
    {
        public Contactos[] contactos;

        public Agenda(int TamanhoArray)
        {
            contactos = new Contactos[TamanhoArray];
        }

        public int adicionaContacto(string Nome, string Telemovel, string Email, string DataNascimento, Bitmap Foto)
        {
            int i = contactoLivre();

            contactos[i] = new Contactos();

            contactos[i].nome = Nome;
            contactos[i].telemovel = Telemovel;
            contactos[i].email = Email;
            contactos[i].dataNascimento = DataNascimento;
            contactos[i].foto = Foto;

            return i+1;
        }

        private int contactoLivre()
        {
            for (int i = 0; i < contactos.Length; i++)
            {
                if (contactos[i] == null)
                {
                    return i;
                }
            }

            return 0;
        }
    }
}
