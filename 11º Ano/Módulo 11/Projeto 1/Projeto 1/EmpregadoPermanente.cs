using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_1
{
    class EmpregadoPermanente : Empregado
    {
        public int DiasTrabalhadosNoMês, NúmeroDeFilhos;
        public double SalárioMensalFixo, BónusMensalPorCrianças, Salário;
        public string estadoCivil;

        public EmpregadoPermanente(string nome, int diasTrabalhadosNoMês, double salárioMensalFixo, int númeroDeFilhos, string estadocivil, double bónusMensalPorCrianças) : base(Estatuto.Permanente, nome)
        {
            Regista(diasTrabalhadosNoMês, salárioMensalFixo, númeroDeFilhos, estadocivil, bónusMensalPorCrianças);
        }

        private void Regista(int diasTrabalhadosNoMês, double salárioMensalFixo, int númeroDeFilhos, string estadocivil, double bónusMensalPorCrianças)
        {
            DiasTrabalhadosNoMês = diasTrabalhadosNoMês;
            SalárioMensalFixo = salárioMensalFixo;
            NúmeroDeFilhos = númeroDeFilhos;
            estadoCivil = estadocivil;
            BónusMensalPorCrianças = bónusMensalPorCrianças;

            Salário = SalárioMensalFixo + ((estadoCivil == EstadoCivil.Casado) ? BónusMensalPorCrianças * NúmeroDeFilhos : 0);
        }

        public override void Informação()
        {
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", nome, estatuto, DiasTrabalhadosNoMês, SalárioMensalFixo, NúmeroDeFilhos, estadoCivil, BónusMensalPorCrianças, Salário);
        }
    }

    static class EstadoCivil
    {
        public const string Solteiro = "Solteiro";
        public const string Casado = "Casado";
        public const string Divorciado = "Divorciado";
        public const string Viuvo = "Viuvo";
    }
}
