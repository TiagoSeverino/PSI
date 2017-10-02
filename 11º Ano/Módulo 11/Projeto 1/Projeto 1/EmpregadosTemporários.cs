using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_1
{
    class EmpregadoTemporário : Empregado
    {
        public double SalárioPorHora;
        public int HorasTrabalhadasNoMês;

        public EmpregadoTemporário(string nome, double salárioPorHora, int horasTrabalhadasNoMês) : base(Estatuto.Temporário, nome)
        {
            SalárioPorHora = salárioPorHora;
            HorasTrabalhadasNoMês = horasTrabalhadasNoMês;
        }

        public override void Informação()
        {
            Console.WriteLine("{0} {1} {2} {3}", nome, estatuto, SalárioPorHora, HorasTrabalhadasNoMês);
        }
    }
}
