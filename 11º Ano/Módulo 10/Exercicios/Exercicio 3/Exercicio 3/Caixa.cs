using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class Caixa : Funcionario
    {
        public string Nome { get; set; }
        public double Salário { get; set; }
        public int Balcão { get; set; }

        public string aumentaSalário()
        {
            Salário += Salário * 0.1;
            return "Novo Salário: " + Salário;
        }

        public string mostraDados()
        {
            return "Nome: " + Nome + " Salário: " + Salário + " Balcão: " + Balcão;
        }
    }
}
