using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_de_Avalicação
{
    class Equipa
    {
        public string nome { get; set; }
        List<Carro> carros = new List<Carro>();

        public Equipa(Carro Carro1, Carro Carro2, Carro Carro3)
        {
            carros.Add(Carro1);
            carros.Add(Carro2);
            carros.Add(Carro3);
        }
    }
}
