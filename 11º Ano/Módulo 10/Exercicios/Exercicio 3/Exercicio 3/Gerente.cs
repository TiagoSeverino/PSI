using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class Gerente : Funcionario
    {
        public string Nome { get; set; }
        public double Salário { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }

        public string aumentaSalário()
        {
            Salário += Salário * 0.2;
            return "Novo Salário: " + Salário;
        }

        public string mostraDados()
        {
            return "Nome: " + Nome + " Salário: " + Salário + " Nome de Utilizador: " + User + " Palavra-Passe: " + Pass;
        }
    }
}
