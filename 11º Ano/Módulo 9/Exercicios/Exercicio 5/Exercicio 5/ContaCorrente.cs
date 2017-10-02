using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    class ContaCorrente
    {
        public int numeroConta { get; set; }
        public string titular { get; set; }
        public double saldo { get; set; }

        public ContaCorrente(int NumeroConta, string Titular, double Saldo)
        {
            if (NumeroConta > 0)
                numeroConta = NumeroConta;
            titular = Titular;

            deposita(Saldo);
        }

        public bool deposita(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                return true;
            }
            return false;
        }

        public bool levantamento(double valor)
        {
            if(valor > 0 && valor <= saldo)
            {
                saldo -= valor;
                return true;
            }

            return false;
        }

        public bool transfere(double valor, ContaCorrente c2)
        {
            if (valor > 0 && valor <= saldo)
            {
                levantamento(valor);
                c2.deposita(valor);
                return true;
            }

            return false;
        }
    }
}
