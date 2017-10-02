using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_1
{
    class EmpregadoVendedor : EmpregadoTemporário
    {
        public double VolumeVendas, Comissão;

        public EmpregadoVendedor(string nome, double salárioPorHora, int horasTrabalhadasNoMês, double volumeVendas, double comissão) : base(nome, salárioPorHora, horasTrabalhadasNoMês)
        {
            VolumeVendas = volumeVendas;
            Comissão = comissão;
        }

        public override void Informação()
        {
            Console.WriteLine("{0} {1} {2} {3} {4} {5}", nome, estatuto, SalárioPorHora, HorasTrabalhadasNoMês, VolumeVendas, Comissão);
        }
    }
}
