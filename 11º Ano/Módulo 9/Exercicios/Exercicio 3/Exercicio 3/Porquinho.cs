using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class Porquinho
    {
        public double montante;
        public double getMontante()
        {
            return montante;
        }

        public void visor()
        {
            if(montante == 0)
            {
                Console.WriteLine("Está sem um tostão!");
            }
            else
            {
                Console.WriteLine("Tem {0} euros no mealheiro", montante);
            }
        }

        public void abanar()
        {
            if (montante != 0)
            {
                Console.WriteLine("Bing, Bing!");
            }
        }

        public void encher(double valor)
        {
            if (valor > 0)
            {
                montante += valor;
            }
        }

        public void esvaziar()
        {
            montante = 0;
        }

        public void tirar(double valor)
        {
            if (valor > 0)
            {
                if (valor >= montante)
                {
                    esvaziar();
                }
                else
                {
                    montante -= valor;
                }
            }
        }

        public bool montanteSuficiente(double valor,ref double saldo)
        {
            saldo = montante - valor;
            return (montante >= valor) ? true : false;
        }
    }
}
