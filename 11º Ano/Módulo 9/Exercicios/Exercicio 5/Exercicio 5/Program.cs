using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente(0, "João Silva", 300);

            conta1.deposita(200);

            conta1.levantamento(400);

            ContaCorrente conta2 = new ContaCorrente(1, "Ana Silva", 100);

            conta1.transfere(100, conta2);

            Console.WriteLine("Saldo Conta 1: {0}, Saldo Conta 2: {1}", conta1.saldo, conta2.saldo);

            Console.ReadLine();
        }
    }
}
