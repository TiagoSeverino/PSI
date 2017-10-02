using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_de_Avalicação
{
    class Corrida
    {
        public int nrCarros { get; set; } = 0;
        public int nrCorrida { get; set; }
        public int MaxCarros { get; set; }
        public string localCorrida { get; set; }
        public DateTime dataCorrida { get; set; }

        List<Carro> carros = new List<Carro>();

        public void adicionarCarro(Carro carro)
        {
            if (nrCarros < MaxCarros)
            {
                carros.Add(carro);
                nrCarros++;
            }
        }
    }
}
