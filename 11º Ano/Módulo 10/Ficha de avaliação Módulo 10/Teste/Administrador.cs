    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Administrador : Empregado
    {
        double AjudasDeCusto;

        public Administrador(string nome, string endereço, string morada, int códigoSectorTrabalho, double salárioBase, double imposto, double ajudasDeCusto) : base(nome, endereço, morada, códigoSectorTrabalho, salárioBase, imposto)
        {
            AjudasDeCusto = ajudasDeCusto;
        }

        public override void DescrevePessoa()
        {
            Console.WriteLine("Nome: {0}, Endereço: {1} Morada: {2}, Código Sector Trabalho: {3}, Salário Base: {4}, Impostos: {5}, Salário Liquido: {6}", base.Nome, base.Endereço, base.Morada, CódigoSectorTrabalho, SalárioBase, Imposto, CalcularSalário());
        }

        private new double CalcularSalário()
        {
            return (SalárioBase - (SalárioBase * Imposto / 100)) + AjudasDeCusto;
        }
    }
}
