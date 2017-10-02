using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Fornecedor : Pessoa
    {
        double CréditoMáximoConcedido, DívidaFornecedor;

        public Fornecedor(string nome, string endereço, string morada, double créditoMáximoConcedido, double dívidaFornecedor) : base(nome, endereço, morada)
        {
            CréditoMáximoConcedido = créditoMáximoConcedido;
            DívidaFornecedor = dívidaFornecedor;
        }

        public override void DescrevePessoa()
        {
            Console.WriteLine("Nome: {0}, Endereço: {1} Morada: {2}, Crédito Máximo Concedido: {3}, Dívida para com o Fornecedor: {4}, Saldo: {5}", base.Nome, base.Endereço, base.Morada, CréditoMáximoConcedido, DívidaFornecedor, ObterSaldo());
        }

        public double ObterSaldo()
        {
            return CréditoMáximoConcedido - DívidaFornecedor;
        }

    }
}
