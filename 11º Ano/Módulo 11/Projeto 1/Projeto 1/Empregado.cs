using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_1
{
    abstract class Empregado
    {
        public string estatuto, nome;

        public Empregado(string Estatuto, string Nome)
        {
            estatuto = Estatuto;
            nome = Nome;
        }

        public abstract void Informação();
    }

    public static class Estatuto{
        public const string Permanente = "Permanente";
        public const string Temporário = "Temporário";
    }
}
