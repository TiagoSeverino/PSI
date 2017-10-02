using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Cão : Animal
    {
        public string especie { get; set; } = "Cão";
        public string Nome { get; set; }
        public string som { get; set; } = "Woof Woof";
        public string raça { get; set; }

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
