using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlo_Remoto
{
    class ControloRemoto
    {
        private int maxCanais, maxVolume;

        public int canal { get; set; }
        public int volume { get; set; }

        public ControloRemoto(int MaximoCanais, int MaximoVolume)
        {
            maxCanais = MaximoCanais;
            maxVolume = MaximoVolume;

            canal = 0;
            volume = 0;
        }

        public void controloVolume(bool som = true)
        {
            if (som)
            {
                if ((volume + 1) >= 0 && (volume + 1) < maxVolume)
                    volume++;
            }
            else
            {
                if ((volume - 1) >= 0)
                    volume--;
            }
            
        }

        public void controloCanal(bool Canal, int adicao = 1)
        {
            if (Canal)
            {
                if ((canal + adicao) >= 0 && (canal + adicao) < maxCanais)
                    canal += adicao;
            }
            else
            {
                if ((canal - adicao) >= 0 && (canal - adicao) < maxCanais)
                    canal -= adicao;
            }
        }
    }
}
