using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, despesas, diferenca;

            Console.WriteLine("Insira o seu salário");
            salario = double.Parse(Console.ReadLine());

            despesas = obterValor("da sua caixa:");
            despesas += obterValor("de água:");
            despesas += obterValor("de luz:");
            despesas += obterValor("de telefone:");
            despesas += obterValor("de renda:");

            diferenca = salario - despesas;

            if (diferenca <= 50)
                Console.Write("Atenção! ");

            Console.WriteLine("Irão sobrar " + diferenca + " euros do seu salário");

            Console.ReadLine();
        }

        private static double obterValor(string s)
        {
            Console.WriteLine("Insira o valor que paga " + s);
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine(r);
            return r;
        }
    }
}
