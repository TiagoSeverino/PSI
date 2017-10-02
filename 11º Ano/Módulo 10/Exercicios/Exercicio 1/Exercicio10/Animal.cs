using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    interface Animal
    {
        string Nome { get; set; }
        string som { get; set; }
        string Som();
        string especie { get; set; }
    }
}
