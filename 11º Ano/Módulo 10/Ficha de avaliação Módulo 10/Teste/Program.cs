using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Program
    {
        static string f = "Fornecedor";
        static string e = "Empregado";
        static string a = "Administrador";

        static void Main(string[] args)
        {
            new Fornecedor(GetNome(f), GetEndereço(f), GetMorada(f), GetCréditoMáximoConcedido(), GetDívidaFornecedor()).DescrevePessoa();
            new Empregado(GetNome(e), GetEndereço(e), GetMorada(e), GetCódigoSectorTrabalho(e), GetSalárioBase(e), GetImposto(e)).DescrevePessoa();

            new Administrador(GetNome(a), GetEndereço(a), GetMorada(a), GetCódigoSectorTrabalho(a), GetSalárioBase(a), GetImposto(a), GetAjudasDeCusto()).DescrevePessoa();

            Console.ReadLine();
        }

        static string GetNome(string Profissão)
        {
            Console.WriteLine("\nInsira o Nome do {0}:", Profissão);
            return Console.ReadLine();
        }

        static string GetEndereço(string Profissão)
        {
            Console.WriteLine("Insira o Endereço do {0}:", Profissão);
            return Console.ReadLine();
        }

        static string GetMorada(string Profissão)
        {
            Console.WriteLine("Insira a Morada do {0}:", Profissão);
            return Console.ReadLine();
        }

        static double GetCréditoMáximoConcedido()
        {
            Console.WriteLine("Insira o Crédito Máximo Concedido do Fornecedor:");
            return Double.Parse(Console.ReadLine());
        }

        static double GetDívidaFornecedor()
        {
            Console.WriteLine("Insira a Dívida do Fornecedor:");
            return Double.Parse(Console.ReadLine());
        }

        static int GetCódigoSectorTrabalho(string Profissão)
        {
            Console.WriteLine("Insira o Código do Sector de Trabalho do {0}:", Profissão);
            return int.Parse(Console.ReadLine());
        }

        static double GetSalárioBase(string Profissão)
        {
            Console.WriteLine("Insira o Salário Base do {0}:", Profissão);
            return double.Parse(Console.ReadLine());
        }

        static double GetImposto(string Profissão)
        {
            Console.WriteLine("Insira o Imposto do {0}:", Profissão);
            return double.Parse(Console.ReadLine());
        }

        static double GetAjudasDeCusto()
        {
            Console.WriteLine("Insira as Ajudas de Custo do Administrador:");
            return double.Parse(Console.ReadLine());
        }
    }
}
