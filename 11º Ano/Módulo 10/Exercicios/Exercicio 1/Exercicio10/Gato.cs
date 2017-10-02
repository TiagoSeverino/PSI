using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Gato : Animal
    {
        public string especie { get; set; } = "Gato";
        public string Nome { get; set; }
        public string som { get; set; } = "Mew";
        public double peso{ get; set; }

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
