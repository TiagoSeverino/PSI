using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    interface Funcionario
    {
        string Nome { get; set; }
        double Salário { get; set; }

        string aumentaSalário();

        string mostraDados();
    }
}
