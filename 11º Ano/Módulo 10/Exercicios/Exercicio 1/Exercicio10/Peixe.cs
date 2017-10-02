using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Peixe : Animal
    {
        public string especie { get; set; } = "Peixe";
        public string Nome { get; set; }
        public string som { get; set; } = "Glu Glu";
        public double tamanho { get; set; }

        public void Som()
        {
            Console.WriteLine(som);
        }

        string Animal.Som()
        {
            Console.WriteLine(som);
            return null;
        }
    }
}
