using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlo_Remoto
{
    class Televisão
    {
        public double polegadas { get; set; }
        public double peso { get; set; }
        public int canais { get; set; }
        public bool isLigada { get; set; } = false;
        public ControloRemoto rc { get; set; }

        public Televisão(double Polegadas, double Peso, int Canais, int MaximoVolume)
        {
            rc = new ControloRemoto(Canais, MaximoVolume);
            polegadas = Polegadas;
            peso = Peso;
            canais = Canais;
        }

        public void ligar()
        {
            rc.canal = 0;
            rc.volume = 0;
            isLigada = true;
        }

        public void desligar()
        {
            isLigada = false;
        }

        public bool estaLigada()
        {
            return isLigada;
        }
    }
}
