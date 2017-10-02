using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class Telefonista : Funcionario
    {
        public string Nome { get; set; }
        public double Salário { get; set; }
        public string CodeEstação { get; set; }

        public string aumentaSalário()
        {
            Salário += Salário * 0.1;
            return "Novo Salário: " + Salário;
        }

        public string mostraDados()
        {
            return "Nome: " + Nome + " Salário: " + Salário + " Código de Estação: " + CodeEstação;
        }
    }
}
